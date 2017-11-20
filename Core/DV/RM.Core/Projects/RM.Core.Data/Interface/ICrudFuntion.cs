using RM.Core.Business.Entities.Views;
using System;
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

        string UpdateTypeUser(BizTypeUser bizTypeUser);
        string UpdateTypeCommittee(BizTypeCommittee bizTypeCommittee);
        string UpdateTypeVisit(BizTypeVisit bizTypeVisit);
        string UpdateRecreationalArea(BizRecreationalArea bizRecreationalArea);
        string UpdateEventuality(BizEventuality bizEventuality);
        string UpdateTicketStatus(BizTicketStatus bizTicketStatus);
        string UpdatePaymentStatus(BizPaymentStatus bizPaymentStatus);
        string UpdateEventStatus(BizEventStatus bizEventStatus);
        string UpdateSupplier(BizSupplier bizSupplier);
        string UpdateCompany(BizCompany bizCompany);
        string UpdateUser(BizUser bizUser);
        string UpdateVehicle(BizVehicle bizVehicle);
        string UpdateAddress(BizAddress bizAddress);
        string UpdateCommitteeMember(BizCommitteeMember bizCommitteeMember);
        string UpdateEvent(BizEvent bizEvent);
        string UpdateTicket(BizTicket bizTicket);
        string UpdateVisit(BizVisit bizVisit);
        string UpdateAssistControl(BizAssistControl bizAssistControl);
        string UpdatePayment(BizPayment bizPayment);

        #endregion

        #region GET

        List<BizTypeUser> GetTypeUser(int? Id = null, bool? Active = null);
        List<BizTypeCommittee> GetTypeCommittee(int? Id = null, bool? Active = null);
        List<BizTypeVisit> GetTypeVisit(int? Id = null, bool? Active = null);
        List<BizRecreationalArea> GetRecreationalArea(int? Id = null, bool? Active = null);
        List<BizEventuality> GetEventuality(int? Id = null, bool? Active = null);
        List<BizTicketStatus> GetTicketStatus(int? Id = null, bool? Active = null);
        List<BizPaymentStatus> GetPaymentStatus(int? Id = null, bool? Active = null);
        List<BizEventStatus> GetEventStatus(int? Id = null, bool? Active = null);
        List<BizSupplier> GetSupplier(int? Id = null, bool? Active = null);
        List<BizCompany> GetCompany(int? Id = null, bool? Active = null);
        List<BizUser> GetUser(int? Id = null, bool? Active = null);
        List<BizVehicle> GetVehicle(int? Id = null, bool? Active = null);
        List<BizAddress> GetAddress(int? Id = null, bool? Active = null);
        List<BizCommitteeMember> GetCommitteeMember(int? Id = null, bool? Active = null);
        List<BizEvent> GetEvent(int? Id = null, bool? Active = null);
        List<BizTicket> GetTicket(int? Id = null, bool? Active = null);
        List<BizVisit> GetVisit(int? Id = null, bool? Active = null);
        List<BizAssistControl> GetAssistControl(int? Id = null, bool? Active = null);
        List<BizPayment> GetPayment(int? Id = null, bool? Active = null);
        List<BizInternalBox> GetInternalBox(decimal? Amount, DateTime? CreationDate);
        List<BizInternalExpense> GetInternalExpense(int? Id = null, bool? Active = null);

        #endregion

        #region DELETE
        #endregion

    }
}
