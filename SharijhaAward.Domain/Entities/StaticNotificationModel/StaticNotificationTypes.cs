using System.ComponentModel;

namespace SharijhaAward.Domain.Entities.StaticNotificationModel
{
    public enum StaticNotificationTypes
    {
        [Description("Confirm and send the form - تأكيد وإرسال الاستمارة")]
        AfterSigningTheForm = 1,
        [Description("Confirm and send the winning forms - تأكيد وإرسال نتائج الفائزين")]
        ConfirmSelectedWinningForms = 2,
        [Description("Send relating request - إرسال طلب ارتباط")]
        SendRelatingRequest = 3
        //AfterOneWeekWithNoUpdatesOnTheSubscriptionForm = 2,
        //CompleteTheRegistrationStepsOnTheForm = 3,
        //OneOfTheItemsInTheFormWasRejectedByTheCoordinator = 4,
        //WhenAddingANewFieldWithinACategory = 5,
        //OneOfTheItemsInTheFormWasRejectedByTheArbitrator = 6,
        //WhenAddingAwardNews = 7,
        //LinkedAccountsWhenSendingAnInvitationToAnAccount = 8,
        //LinkedAccountsWhenAcceptingAnInvitationToAnAccount = 9,
        //ChangeInCycleStatus = 10,
        //ChangeInAgendaStatus = 11,
        //ChangePasswordFromDashboard = 12,
        //ChangePasswordFromSubscriberAccount = 13,
        //NotifyUsersOfInterviews = 14,
        //ApplicationDeadlines = 15,
        //PasswordChangedByAdmin = 16,
        //ANewFieldHasBeenAddedForCoordinatorData = 17,
        //ModifyAFieldInAFormByTheSubscriber = 18,
        //ArbitratedByAnAppointedArbitrator = 19,
        //TheFormsHaveBeenSorted = 20,
        //TheFormsHaveBeenAssigned = 21,
        //AddARefereeToTheCommittee = 22,
        //DoneInitialArbitration = 23,
        //TheSummaryOfTheArbitrationHasBeenPrepared = 24,
        //DoneFinalArbitration = 25,
        //TheFormDataHasBeenUpdatedByTheSubscriber = 26,
        //AssignmentFormToArbitrator = 27,
        //FinalArbitrationDeadlines = 28,
        //AnnouncementOfInterviewsOfArbitrators = 29,

    }
}
