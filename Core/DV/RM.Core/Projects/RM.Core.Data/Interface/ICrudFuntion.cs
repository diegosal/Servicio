using RM.Core.Business.Entities.Views;
using System;
using System.Collections.Generic;

namespace RM.Core.Data.Interface
{
    /// <summary>
    /// Interface ICrudFuntion
    /// </summary>
    interface ICrudFuntion
    {

        #region INSERT

        /// <summary>
        /// Inserts the type user.
        /// </summary>
        /// <param name="bizTypeUser">The biz type user.</param>
        /// <returns>System.String.</returns>
        string InsertTypeUser(BizTypeUser bizTypeUser);
        /// <summary>
        /// Inserts the type committee.
        /// </summary>
        /// <param name="bizTypeCommittee">The biz type committee.</param>
        /// <returns>System.String.</returns>
        string InsertTypeCommittee(BizTypeCommittee bizTypeCommittee);
        /// <summary>
        /// Inserts the type visit.
        /// </summary>
        /// <param name="bizTypeVisit">The biz type visit.</param>
        /// <returns>System.String.</returns>
        string InsertTypeVisit(BizTypeVisit bizTypeVisit);
        /// <summary>
        /// Inserts the recreational area.
        /// </summary>
        /// <param name="bizRecreationalArea">The biz recreational area.</param>
        /// <returns>System.String.</returns>
        string InsertRecreationalArea(BizRecreationalArea bizRecreationalArea);
        /// <summary>
        /// Inserts the eventuality.
        /// </summary>
        /// <param name="bizEventuality">The biz eventuality.</param>
        /// <returns>System.String.</returns>
        string InsertEventuality(BizEventuality bizEventuality);
        /// <summary>
        /// Inserts the ticket status.
        /// </summary>
        /// <param name="bizTicketStatus">The biz ticket status.</param>
        /// <returns>System.String.</returns>
        string InsertTicketStatus(BizTicketStatus bizTicketStatus);
        /// <summary>
        /// Inserts the payment status.
        /// </summary>
        /// <param name="bizPaymentStatus">The biz payment status.</param>
        /// <returns>System.String.</returns>
        string InsertPaymentStatus(BizPaymentStatus bizPaymentStatus);
        /// <summary>
        /// Inserts the event status.
        /// </summary>
        /// <param name="bizEventStatus">The biz event status.</param>
        /// <returns>System.String.</returns>
        string InsertEventStatus(BizEventStatus bizEventStatus);
        /// <summary>
        /// Inserts the supplier.
        /// </summary>
        /// <param name="bizSupplier">The biz supplier.</param>
        /// <returns>System.String.</returns>
        string InsertSupplier(BizSupplier bizSupplier);
        /// <summary>
        /// Inserts the company.
        /// </summary>
        /// <param name="bizCompany">The biz company.</param>
        /// <returns>System.String.</returns>
        string InsertCompany(BizCompany bizCompany);
        /// <summary>
        /// Inserts the user.
        /// </summary>
        /// <param name="bizUser">The biz user.</param>
        /// <returns>System.String.</returns>
        string InsertUser(BizUser bizUser);
        /// <summary>
        /// Inserts the vehicle.
        /// </summary>
        /// <param name="bizVehicle">The biz vehicle.</param>
        /// <returns>System.String.</returns>
        string InsertVehicle(BizVehicle bizVehicle);
        /// <summary>
        /// Inserts the address.
        /// </summary>
        /// <param name="bizAddress">The biz address.</param>
        /// <returns>System.String.</returns>
        string InsertAddress(BizAddress bizAddress);
        /// <summary>
        /// Inserts the committee member.
        /// </summary>
        /// <param name="bizCommitteeMember">The biz committee member.</param>
        /// <returns>System.String.</returns>
        string InsertCommitteeMember(BizCommitteeMember bizCommitteeMember);
        /// <summary>
        /// Inserts the event.
        /// </summary>
        /// <param name="bizEvent">The biz event.</param>
        /// <returns>System.String.</returns>
        string InsertEvent(BizEvent bizEvent);
        /// <summary>
        /// Inserts the ticket.
        /// </summary>
        /// <param name="bizTicket">The biz ticket.</param>
        /// <returns>System.String.</returns>
        string InsertTicket(BizTicket bizTicket);
        /// <summary>
        /// Inserts the visit.
        /// </summary>
        /// <param name="bizVisit">The biz visit.</param>
        /// <returns>System.String.</returns>
        string InsertVisit(BizVisit bizVisit);
        /// <summary>
        /// Inserts the assist control.
        /// </summary>
        /// <param name="bizAssistControl">The biz assist control.</param>
        /// <returns>System.String.</returns>
        string InsertAssistControl(BizAssistControl bizAssistControl);
        /// <summary>
        /// Inserts the payment.
        /// </summary>
        /// <param name="bizPayment">The biz payment.</param>
        /// <returns>System.String.</returns>
        string InsertPayment(BizPayment bizPayment);
        /// <summary>
        /// Inserts the internal box.
        /// </summary>
        /// <param name="bizInternalBox">The biz internal box.</param>
        /// <returns>System.String.</returns>
        string InsertInternalBox(BizInternalBox bizInternalBox);
        /// <summary>
        /// Inserts the internal expense.
        /// </summary>
        /// <param name="bizInternalExpense">The biz internal expense.</param>
        /// <returns>System.String.</returns>
        string InsertInternalExpense(BizInternalExpense bizInternalExpense);

        #endregion

        #region UPDATE

        /// <summary>
        /// Updates the type user.
        /// </summary>
        /// <param name="bizTypeUser">The biz type user.</param>
        /// <returns>System.String.</returns>
        string UpdateTypeUser(BizTypeUser bizTypeUser);
        /// <summary>
        /// Updates the type committee.
        /// </summary>
        /// <param name="bizTypeCommittee">The biz type committee.</param>
        /// <returns>System.String.</returns>
        string UpdateTypeCommittee(BizTypeCommittee bizTypeCommittee);
        /// <summary>
        /// Updates the type visit.
        /// </summary>
        /// <param name="bizTypeVisit">The biz type visit.</param>
        /// <returns>System.String.</returns>
        string UpdateTypeVisit(BizTypeVisit bizTypeVisit);
        /// <summary>
        /// Updates the recreational area.
        /// </summary>
        /// <param name="bizRecreationalArea">The biz recreational area.</param>
        /// <returns>System.String.</returns>
        string UpdateRecreationalArea(BizRecreationalArea bizRecreationalArea);
        /// <summary>
        /// Updates the eventuality.
        /// </summary>
        /// <param name="bizEventuality">The biz eventuality.</param>
        /// <returns>System.String.</returns>
        string UpdateEventuality(BizEventuality bizEventuality);
        /// <summary>
        /// Updates the ticket status.
        /// </summary>
        /// <param name="bizTicketStatus">The biz ticket status.</param>
        /// <returns>System.String.</returns>
        string UpdateTicketStatus(BizTicketStatus bizTicketStatus);
        /// <summary>
        /// Updates the payment status.
        /// </summary>
        /// <param name="bizPaymentStatus">The biz payment status.</param>
        /// <returns>System.String.</returns>
        string UpdatePaymentStatus(BizPaymentStatus bizPaymentStatus);
        /// <summary>
        /// Updates the event status.
        /// </summary>
        /// <param name="bizEventStatus">The biz event status.</param>
        /// <returns>System.String.</returns>
        string UpdateEventStatus(BizEventStatus bizEventStatus);
        /// <summary>
        /// Updates the supplier.
        /// </summary>
        /// <param name="bizSupplier">The biz supplier.</param>
        /// <returns>System.String.</returns>
        string UpdateSupplier(BizSupplier bizSupplier);
        /// <summary>
        /// Updates the company.
        /// </summary>
        /// <param name="bizCompany">The biz company.</param>
        /// <returns>System.String.</returns>
        string UpdateCompany(BizCompany bizCompany);
        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="bizUser">The biz user.</param>
        /// <returns>System.String.</returns>
        string UpdateUser(BizUser bizUser);
        /// <summary>
        /// Updates the vehicle.
        /// </summary>
        /// <param name="bizVehicle">The biz vehicle.</param>
        /// <returns>System.String.</returns>
        string UpdateVehicle(BizVehicle bizVehicle);
        /// <summary>
        /// Updates the address.
        /// </summary>
        /// <param name="bizAddress">The biz address.</param>
        /// <returns>System.String.</returns>
        string UpdateAddress(BizAddress bizAddress);
        /// <summary>
        /// Updates the committee member.
        /// </summary>
        /// <param name="bizCommitteeMember">The biz committee member.</param>
        /// <returns>System.String.</returns>
        string UpdateCommitteeMember(BizCommitteeMember bizCommitteeMember);
        /// <summary>
        /// Updates the event.
        /// </summary>
        /// <param name="bizEvent">The biz event.</param>
        /// <returns>System.String.</returns>
        string UpdateEvent(BizEvent bizEvent);
        /// <summary>
        /// Updates the ticket.
        /// </summary>
        /// <param name="bizTicket">The biz ticket.</param>
        /// <returns>System.String.</returns>
        string UpdateTicket(BizTicket bizTicket);
        /// <summary>
        /// Updates the visit.
        /// </summary>
        /// <param name="bizVisit">The biz visit.</param>
        /// <returns>System.String.</returns>
        string UpdateVisit(BizVisit bizVisit);
        /// <summary>
        /// Updates the assist control.
        /// </summary>
        /// <param name="bizAssistControl">The biz assist control.</param>
        /// <returns>System.String.</returns>
        string UpdateAssistControl(BizAssistControl bizAssistControl);
        /// <summary>
        /// Updates the payment.
        /// </summary>
        /// <param name="bizPayment">The biz payment.</param>
        /// <returns>System.String.</returns>
        string UpdatePayment(BizPayment bizPayment);

        #endregion

        #region GET

        /// <summary>
        /// Gets the type user.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizTypeUser&gt;.</returns>
        List<BizTypeUser> GetTypeUser(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the type committee.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizTypeCommittee&gt;.</returns>
        List<BizTypeCommittee> GetTypeCommittee(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the type visit.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizTypeVisit&gt;.</returns>
        List<BizTypeVisit> GetTypeVisit(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the recreational area.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizRecreationalArea&gt;.</returns>
        List<BizRecreationalArea> GetRecreationalArea(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the eventuality.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizEventuality&gt;.</returns>
        List<BizEventuality> GetEventuality(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the ticket status.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizTicketStatus&gt;.</returns>
        List<BizTicketStatus> GetTicketStatus(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the payment status.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizPaymentStatus&gt;.</returns>
        List<BizPaymentStatus> GetPaymentStatus(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the event status.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizEventStatus&gt;.</returns>
        List<BizEventStatus> GetEventStatus(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the supplier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizSupplier&gt;.</returns>
        List<BizSupplier> GetSupplier(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the company.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizCompany&gt;.</returns>
        List<BizCompany> GetCompany(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizUser&gt;.</returns>
        List<BizUser> GetUser(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the vehicle.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizVehicle&gt;.</returns>
        List<BizVehicle> GetVehicle(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the address.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizAddress&gt;.</returns>
        List<BizAddress> GetAddress(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the committee member.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizCommitteeMember&gt;.</returns>
        List<BizCommitteeMember> GetCommitteeMember(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the event.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizEvent&gt;.</returns>
        List<BizEvent> GetEvent(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the ticket.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizTicket&gt;.</returns>
        List<BizTicket> GetTicket(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the visit.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizVisit&gt;.</returns>
        List<BizVisit> GetVisit(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the assist control.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizAssistControl&gt;.</returns>
        List<BizAssistControl> GetAssistControl(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the payment.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizPayment&gt;.</returns>
        List<BizPayment> GetPayment(int? Id = null, bool? Active = null);
        /// <summary>
        /// Gets the internal box.
        /// </summary>
        /// <param name="Amount">The amount.</param>
        /// <param name="CreationDate">The creation date.</param>
        /// <returns>List&lt;BizInternalBox&gt;.</returns>
        List<BizInternalBox> GetInternalBox(decimal? Amount, DateTime? CreationDate);
        /// <summary>
        /// Gets the internal expense.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizInternalExpense&gt;.</returns>
        List<BizInternalExpense> GetInternalExpense(int? Id = null, bool? Active = null);

        #endregion

        #region DELETE

        /// <summary>
        /// Deletes the type user.
        /// </summary>
        /// <param name="bizTypeUser">The biz type user.</param>
        /// <returns>System.String.</returns>
        string DeleteTypeUser(BizTypeUser bizTypeUser);
        /// <summary>
        /// Deletes the type committee.
        /// </summary>
        /// <param name="bizTypeCommittee">The biz type committee.</param>
        /// <returns>System.String.</returns>
        string DeleteTypeCommittee(BizTypeCommittee bizTypeCommittee);
        /// <summary>
        /// Deletes the type visit.
        /// </summary>
        /// <param name="bizTypeVisit">The biz type visit.</param>
        /// <returns>System.String.</returns>
        string DeleteTypeVisit(BizTypeVisit bizTypeVisit);
        /// <summary>
        /// Deletes the recreational area.
        /// </summary>
        /// <param name="bizRecreationalArea">The biz recreational area.</param>
        /// <returns>System.String.</returns>
        string DeleteRecreationalArea(BizRecreationalArea bizRecreationalArea);
        /// <summary>
        /// Deletes the eventuality.
        /// </summary>
        /// <param name="bizEventuality">The biz eventuality.</param>
        /// <returns>System.String.</returns>
        string DeleteEventuality(BizEventuality bizEventuality);
        /// <summary>
        /// Deletes the ticket status.
        /// </summary>
        /// <param name="bizTicketStatus">The biz ticket status.</param>
        /// <returns>System.String.</returns>
        string DeleteTicketStatus(BizTicketStatus bizTicketStatus);
        /// <summary>
        /// Deletes the payment status.
        /// </summary>
        /// <param name="bizPaymentStatus">The biz payment status.</param>
        /// <returns>System.String.</returns>
        string DeletePaymentStatus(BizPaymentStatus bizPaymentStatus);
        /// <summary>
        /// Deletes the event status.
        /// </summary>
        /// <param name="bizEventStatus">The biz event status.</param>
        /// <returns>System.String.</returns>
        string DeleteEventStatus(BizEventStatus bizEventStatus);
        /// <summary>
        /// Deletes the supplier.
        /// </summary>
        /// <param name="bizSupplier">The biz supplier.</param>
        /// <returns>System.String.</returns>
        string DeleteSupplier(BizSupplier bizSupplier);
        /// <summary>
        /// Deletes the company.
        /// </summary>
        /// <param name="bizCompany">The biz company.</param>
        /// <returns>System.String.</returns>
        string DeleteCompany(BizCompany bizCompany);
        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="bizUser">The biz user.</param>
        /// <returns>System.String.</returns>
        string DeleteUser(BizUser bizUser);
        /// <summary>
        /// Deletes the vehicle.
        /// </summary>
        /// <param name="bizVehicle">The biz vehicle.</param>
        /// <returns>System.String.</returns>
        string DeleteVehicle(BizVehicle bizVehicle);
        /// <summary>
        /// Deletes the address.
        /// </summary>
        /// <param name="bizAddress">The biz address.</param>
        /// <returns>System.String.</returns>
        string DeleteAddress(BizAddress bizAddress);
        /// <summary>
        /// Deletes the committee member.
        /// </summary>
        /// <param name="bizCommitteeMember">The biz committee member.</param>
        /// <returns>System.String.</returns>
        string DeleteCommitteeMember(BizCommitteeMember bizCommitteeMember);

        #endregion

    }
}
