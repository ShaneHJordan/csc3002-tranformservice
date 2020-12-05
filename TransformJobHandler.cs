using Dapper;
using Npgsql;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ReportsDatabaseTransformService
{
    public class TransformJobHandler : IAsyncDisposable
    {
        private readonly SqlConnection sqlServerConnection;
        private readonly NpgsqlConnection npgsqlConnection;

        public TransformJobHandler()
        {
            string sqlServerConnectionString = "Data Source=host.docker.internal; Database=Certification;User Id=sa;Pwd=Trintech1";
            sqlServerConnection = new SqlConnection(sqlServerConnectionString);

            string npgsqlConnectionString = "Server=host.docker.internal;Port=5432;Database=postgres;User Id=postgres;Password=Trintech1;";

            npgsqlConnection = new NpgsqlConnection(npgsqlConnectionString);
        }


        public async Task DoWork()
        {
            try
            {
                var results = sqlServerConnection.Query<SummaryReportResult>("SELECT * FROM fnReportJEJournal_Static_2(NULL, '', 'PM', '', '', 'EQUAL_TO', '', '')", buffered: false);

                foreach (var result in results)
                {
                    result.Id = Guid.NewGuid();
                    npgsqlConnection.Execute(InsertIntoPostGresQuery.InsertQuery, result);
                    Console.WriteLine($"SQl SERVER Result with id {result.Id} has a posting designation: {result.JEPostingDesignation}");
                }

                var postGreSqlResults = npgsqlConnection.Query<SummaryReportResult>("SELECT * FROM public.\"Summary\"", buffered: false);

                foreach (var result in postGreSqlResults)
                {
                    Console.WriteLine($"POSTGRES Result with id {result.Id} has a posting designation: {result.JEPostingDesignation}");
                }

            } catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }


            // Console.WriteLine($"First Full name in Sql server db is: {firstUserFullName}");

            //try
            //{

            //    string postGreSqlResult = await npgsqlConnection.QueryFirstAsync<string>("SELECT \"Name\" FROM public.\"Test\"");
            //    Console.WriteLine($"PostGreSql result is: {postGreSqlResult}");

            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine($"{e}");
            //}

        }


        public async ValueTask DisposeAsync()
        {
            await sqlServerConnection.DisposeAsync();
            await npgsqlConnection.DisposeAsync();
        }
    }
}
