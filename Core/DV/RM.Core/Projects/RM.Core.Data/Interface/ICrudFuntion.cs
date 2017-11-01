using RM.Core.Business.Entities.Views;
using System.Collections.Generic;

namespace RM.Core.Data.Interface
{
    interface ICrudFuntion
    {

        #region INSERT

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

        #endregion

        #region UPDATE
        #endregion

        #region GET

        List<BizTypeUser> GetTypeUser(int Id, bool Active);
        List<BizTypeCommittee> GetTypeCommittee(int Id, bool Active);
        List<BizTypeVisit> GetTypeVisit(BizTypeVisit bizTypeVisit);
        List<BizRecreationalArea> GetRecreationalArea(int Id, bool Active);
        List<BizEventuality> GetEventuality(int Id, bool Active);
        List<BizTicketStatus> GetTicketStatus(int Id, bool Active);
        List<BizPaymentStatus> GetPaymentStatus(int Id, bool Active);
        List<BizEventStatus> GetEventStatus(int Id, bool Active);
        List<BizSupplier> GetSupplier(int Id, bool Active);
        List<BizCompany> GetCompany(int Id, bool Active);
        List<BizUser> GetUser(int Id, bool Active);
        List<BizVehicle> GetVehicle(int Id, bool Active);
        List<BizAddress> GetAddress(int Id, bool Active);
        List<BizCommitteeMember> GetCommitteeMember(int Id, bool Active);
        List<BizEvent> GetEvent(int Id, bool Active);
        List<BizTicket> GetTicket(int Id, bool Active);
        List<BizVisit> GetVisit(int Id, bool Active);
        List<BizAssistControl> GetAssistControl(int Id, bool Active);
        List<BizPayment> GetPayment(int Id, bool Active);
        List<BizInternalBox> GetInternalBox(int Id, bool Active);
        List<BizInternalExpense> GetInternalExpense(int Id, bool Active);

        #endregion

        #region DELETE
        #endregion

    }
}
