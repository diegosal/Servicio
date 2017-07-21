using RM.Core.Business.Entities.Views;

namespace RM.Core.Data.Interface
{
    interface IInsert
    {
        string InsertTypeUser(BizTypeUser bizTypeUser);
        string InsertTypeCommittee(BizTypeCommittee bizTypeCommittee);
        string InsertTypeVisit(BizTypeVisit bizTypeVisit);
        string InsertRecreationalArea(BizRecreationalArea bizRecreationalArea);
        string InsertEventuality(BizEventuality bizEventuality);
        string InsertTicketStatus(BizTicketStatus bizTicketStatus);
        string InsertPaymentStatus(BizPaymentStatus bizPaymentStatus);
        string InsertEventStatus(BizEventStatus bizEventStatus);
        string InsertSupplier(BizSupplier bizSupplier);
        string InsertCompany(BizCompany bizCompany);
        string InsertUser(BizUser bizUser);
        string InsertVehicle(BizVehicle bizVehicle);
        string InsertAddress(BizAddress bizAddress);
        string InsertCommitteeMember(BizCommitteeMember bizCommitteeMember);
        string InsertEvent(BizEvent bizEvent);
        string InsertTicket(BizTicket bizTicket);
        string InsertVisit(BizVisit bizVisit);
        string InsertAssistControl(BizAssistControl bizAssistControl);
        string InsertPayment(BizPayment bizPayment);
        string InsertInternalBox(BizInternalBox bizInternalBox);
        string InsertInternalExpense(BizInternalExpense bizInternalExpense);
    }
}
