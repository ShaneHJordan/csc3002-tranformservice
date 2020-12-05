using System;

namespace ReportsDatabaseTransformService
{
    public class SummaryReportResult
    {
        public Guid Id { get; set; }

        public string JEPostingDesignation { get; set; }

        public DateTime? DateCreated { get; set; }

        public string JECreationSource { get; set; }

        public string Name { get; set; }

        public string ScheduledRecurring { get; set; }

        public string IsApproverCustomized { get; set; }

        public string IsPostedSuccessfullyToERP { get; set; }

        public string PostingDescription { get; set; }

        public string PostingMethod { get; set; }

        public string PostingDestination { get; set; }

        public string BypassPosting { get; set; }

        public string PeriodDisplay { get; set; }

        public int? Period { get; set; }

        public int? JE_Period_Year { get; set; }

        public string TemplateDescription { get; set; }

        public string TemplateName { get; set; }

        public string TemplateActive { get; set; }

        public string ApproverIsOptional { get; set; }

        public string TemplatePostingRule { get; set; }

        public string RequireFiles { get; set; }

        public int? FileCount { get; set; }

        public string PrepName { get; set; }

        public string PrepStatus { get; set; }

        public string App1Name { get; set; }

        public string App2Name { get; set; }
        public string App3Name { get; set; }
        public string App4Name { get; set; }
        public string App5Name { get; set; }
        public string App6Name { get; set; }

        public string App1Status { get; set; }

        public string App2Status { get; set; }
        public string App3Status { get; set; }
        public string App4Status { get; set; }
        public string App5Status { get; set; }
        public string App6Status { get; set; }

        public string CreatedByName { get; set; }

        public string JENotes { get; set; }

        public string ANETLinkName { get; set; }

        public string ANETLinkNumber { get; set; }

        public string HasANETLink { get; set; }

        public string PostingHasErrors { get; set; }

        public string PostingComplete { get; set; }

        public decimal? DocumentTotalCredit { get; set; }

        public decimal? DocumentTotalDebit { get; set; }

        public string ConvertedTotal { get; set; }

        public decimal? ConvertedMaxAmount { get; set; }

        public string JE_Description { get; set; }

        public string JE_Document_Number { get; set; }

        public int? JE_Entity { get; set; }

        public string JE_TrintechObjKey { get; set; }

        public string JE_Offset_Account { get; set; }

        public string JE_Offset_Business_Area { get; set; }

        public string JE_Offset_Item_Text { get; set; }

        public string JE_Posted_By { get; set; }

        public DateTime? JE_Posting_Date { get; set; }

        public string JE_Recurring { get; set; }

        public DateTime? JE_Reversal_Date { get; set; }

        public string JE_SAPObjKey { get; set; }

        public int? RiskRating { get; set; }

        public string ApprovalStatus { get; set; }

        public string JENotesLink { get; set; }

        public Guid? PeriodFK { get; set; }

        public string RemoteTab { get; set; }
    }
}
