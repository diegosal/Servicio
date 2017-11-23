using System;
using System.Collections.Generic;
using RM.Core.Business.Entities.Views;
using RM.Core.Data.Biz;
using RM.Core.Data.Interface;
using RM.Core.Data.Adapter;

namespace RM.Core.Data.Implementation
{
    /// <summary>
    /// Class CrudFuntion.
    /// </summary>
    /// <seealso cref="RM.Core.Data.Biz.BizLogic" />
    /// <seealso cref="RM.Core.Data.Interface.ICrudFuntion" />
    public class CrudFuntion : BizLogic, ICrudFuntion
    {

        #region INSERT

        /// <summary>
        /// Inserts the address.
        /// </summary>
        /// <param name="bizAddress">The biz address.</param>
        /// <returns>System.String.</returns>
        public string InsertAddress(BizAddress bizAddress)
        {
            string Result = "";
            int  result = 0;
            Result = BizCall(
                new Action(() =>
                    {
                        result = dbContext.SYSInsAddress (
                                bizAddress.UserId, 
                                bizAddress.StreetName, 
                                bizAddress.Number, 
                                bizAddress.PostalCode,
                                bizAddress.Active
                            );
                    }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the assist control.
        /// </summary>
        /// <param name="bizAssistControl">The biz assist control.</param>
        /// <returns>System.String.</returns>
        public string InsertAssistControl(BizAssistControl bizAssistControl)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsAssistControl(
                            bizAssistControl.UserId
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the committee member.
        /// </summary>
        /// <param name="bizCommitteeMember">The biz committee member.</param>
        /// <returns>System.String.</returns>
        public string InsertCommitteeMember(BizCommitteeMember bizCommitteeMember)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsCommitteeMember(
                            bizCommitteeMember.UserId,
                            bizCommitteeMember.CommitteeTypeId,
                            bizCommitteeMember.Active
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the company.
        /// </summary>
        /// <param name="bizCompany">The biz company.</param>
        /// <returns>System.String.</returns>
        public string InsertCompany(BizCompany bizCompany)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsCompany(
                            bizCompany.CompanyName,
                            bizCompany.Active
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the event.
        /// </summary>
        /// <param name="bizEvent">The biz event.</param>
        /// <returns>System.String.</returns>
        public string InsertEvent(BizEvent bizEvent)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsEvent(
                            bizEvent.UserId,
                            bizEvent.RecreationalAreaId,
                            bizEvent.StartDate,
                            bizEvent.EndDate,
                            bizEvent.Status
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the eventuality.
        /// </summary>
        /// <param name="bizEventuality">The biz eventuality.</param>
        /// <returns>System.String.</returns>
        public string InsertEventuality(BizEventuality bizEventuality)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsCatEventuality(
                            bizEventuality.EventualityName,
                            bizEventuality.Active
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the internal box.
        /// </summary>
        /// <param name="bizInternalBox">The biz internal box.</param>
        /// <returns>System.String.</returns>
        public string InsertInternalBox(BizInternalBox bizInternalBox)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsInternalBox(
                            bizInternalBox.Amount
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the internal expense.
        /// </summary>
        /// <param name="bizInternalExpense">The biz internal expense.</param>
        /// <returns>System.String.</returns>
        public string InsertInternalExpense(BizInternalExpense bizInternalExpense)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsInternalExpense(
                            bizInternalExpense.UserId,
                            bizInternalExpense.Amount
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the payment.
        /// </summary>
        /// <param name="bizPayment">The biz payment.</param>
        /// <returns>System.String.</returns>
        public string InsertPayment(BizPayment bizPayment)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsPayment(
                            bizPayment.UserId,
                            bizPayment.Amount,
                            bizPayment.PaymentStatus
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the recreational area.
        /// </summary>
        /// <param name="bizRecreationalArea">The biz recreational area.</param>
        /// <returns>System.String.</returns>
        public string InsertRecreationalArea(BizRecreationalArea bizRecreationalArea)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsCatRecreationalArea(
                            bizRecreationalArea.AreaName,
                            bizRecreationalArea.Active
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the ticket status.
        /// </summary>
        /// <param name="bizTicketStatus">The biz ticket status.</param>
        /// <returns>System.String.</returns>
        public string InsertTicketStatus(BizTicketStatus bizTicketStatus)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsCatTicketStatus(
                            bizTicketStatus.StatusName,
                            bizTicketStatus.Active
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the supplier.
        /// </summary>
        /// <param name="bizSupplier">The biz supplier.</param>
        /// <returns>System.String.</returns>
        public string InsertSupplier(BizSupplier bizSupplier)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsCatSupplier(
                            bizSupplier.SupplierName,
                            bizSupplier.ContactNumer,
                            bizSupplier.Active
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the ticket.
        /// </summary>
        /// <param name="bizTicket">The biz ticket.</param>
        /// <returns>System.String.</returns>
        public string InsertTicket(BizTicket bizTicket)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsTicket(
                            bizTicket.UserId,
                            bizTicket.EventualityId,
                            bizTicket.StatusId
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the type committee.
        /// </summary>
        /// <param name="bizTypeCommittee">The biz type committee.</param>
        /// <returns>System.String.</returns>
        public string InsertTypeCommittee(BizTypeCommittee bizTypeCommittee)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsCatTypeCommittee(
                            bizTypeCommittee.TypeCommittee,
                            bizTypeCommittee.Active
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the type user.
        /// </summary>
        /// <param name="bizTypeUser">The biz type user.</param>
        /// <returns>System.String.</returns>
        public string InsertTypeUser(BizTypeUser bizTypeUser)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsCatTypeUser(
                            bizTypeUser.TypeUser,
                            bizTypeUser.Active
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the type visit.
        /// </summary>
        /// <param name="bizTypeVisit">The biz type visit.</param>
        /// <returns>System.String.</returns>
        public string InsertTypeVisit(BizTypeVisit bizTypeVisit)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsCatTypeVisit(
                           bizTypeVisit.TypeVisit,
                           bizTypeVisit.Active
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the user.
        /// </summary>
        /// <param name="bizUser">The biz user.</param>
        /// <returns>System.String.</returns>
        public string InsertUser(BizUser bizUser)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsUser(
                           bizUser.CompanyId,
                           bizUser.TypeId,
                           bizUser.UserName,
                           bizUser.UserMiddleName,
                           bizUser.UserLastName,
                           bizUser.UserMotherName,
                           bizUser.Email,
                           bizUser.PassWord,
                           bizUser.PassWordSalt,
                           bizUser.Active
                        );
                }
                )
            );

            return Result;
        }

        /// <summary>
        /// Inserts the vehicle.
        /// </summary>
        /// <param name="bizVehicle">The biz vehicle.</param>
        /// <returns>System.String.</returns>
        public string InsertVehicle(BizVehicle bizVehicle)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsVehicle(
                           bizVehicle.UserId,
                           bizVehicle.Plates,
                           bizVehicle.Model,
                           bizVehicle.Active
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the visit.
        /// </summary>
        /// <param name="bizVisit">The biz visit.</param>
        /// <returns>System.String.</returns>
        public string InsertVisit(BizVisit bizVisit)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsVisit(
                           bizVisit.VisitId,
                           bizVisit.UserId,
                           bizVisit.VisitName,
                           bizVisit.Carnet,
                           bizVisit.Plates
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the payment status.
        /// </summary>
        /// <param name="bizPaymentStatus">The biz payment status.</param>
        /// <returns>System.String.</returns>
        public string InsertPaymentStatus(BizPaymentStatus bizPaymentStatus)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsCatPaymentStatus(
                            bizPaymentStatus.StatusName,
                            bizPaymentStatus.Active
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Inserts the event status.
        /// </summary>
        /// <param name="bizEventStatus">The biz event status.</param>
        /// <returns>System.String.</returns>
        public string InsertEventStatus(BizEventStatus bizEventStatus)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsCatEventStatus(
                            bizEventStatus.StatusName,
                            bizEventStatus.Active
                        );
                }
                )
            );
            return Result;
        }

        #endregion

        #region UPDATE

        /// <summary>
        /// Updates the type user.
        /// </summary>
        /// <param name="bizTypeUser">The biz type user.</param>
        /// <returns>System.String.</returns>
        public string UpdateTypeUser(BizTypeUser bizTypeUser)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdCatTypeUser(
                                     bizTypeUser.Id,
                                     bizTypeUser.TypeUser
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the type committee.
        /// </summary>
        /// <param name="bizTypeCommittee">The biz type committee.</param>
        /// <returns>System.String.</returns>
        public string UpdateTypeCommittee(BizTypeCommittee bizTypeCommittee)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdCatTypeCommittee(
                                     bizTypeCommittee.Id,
                                     bizTypeCommittee.TypeCommittee
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the type visit.
        /// </summary>
        /// <param name="bizTypeVisit">The biz type visit.</param>
        /// <returns>System.String.</returns>
        public string UpdateTypeVisit(BizTypeVisit bizTypeVisit)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdCatTypeVisit(
                                     bizTypeVisit.Id,
                                     bizTypeVisit.TypeVisit
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the recreational area.
        /// </summary>
        /// <param name="bizRecreationalArea">The biz recreational area.</param>
        /// <returns>System.String.</returns>
        public string UpdateRecreationalArea(BizRecreationalArea bizRecreationalArea)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdCatRecreationalArea(
                                     bizRecreationalArea.Id,
                                     bizRecreationalArea.AreaName
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the eventuality.
        /// </summary>
        /// <param name="bizEventuality">The biz eventuality.</param>
        /// <returns>System.String.</returns>
        public string UpdateEventuality(BizEventuality bizEventuality)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdCatEventuality(
                                     bizEventuality.Id,
                                     bizEventuality.EventualityName
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the ticket status.
        /// </summary>
        /// <param name="bizTicketStatus">The biz ticket status.</param>
        /// <returns>System.String.</returns>
        public string UpdateTicketStatus(BizTicketStatus bizTicketStatus)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdCatTicketStatus(
                                     bizTicketStatus.Id,
                                     bizTicketStatus.StatusName
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the payment status.
        /// </summary>
        /// <param name="bizPaymentStatus">The biz payment status.</param>
        /// <returns>System.String.</returns>
        public string UpdatePaymentStatus(BizPaymentStatus bizPaymentStatus)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdCatPaymentStatus(
                                     bizPaymentStatus.Id,
                                     bizPaymentStatus.StatusName
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the event status.
        /// </summary>
        /// <param name="bizEventStatus">The biz event status.</param>
        /// <returns>System.String.</returns>
        public string UpdateEventStatus(BizEventStatus bizEventStatus)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdCatEventStatus(
                                     bizEventStatus.Id,
                                     bizEventStatus.StatusName
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the supplier.
        /// </summary>
        /// <param name="bizSupplier">The biz supplier.</param>
        /// <returns>System.String.</returns>
        public string UpdateSupplier(BizSupplier bizSupplier)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdCatSupplier(
                                     bizSupplier.Id,
                                     bizSupplier.SupplierName,
                                     bizSupplier.ContactNumer
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the company.
        /// </summary>
        /// <param name="bizCompany">The biz company.</param>
        /// <returns>System.String.</returns>
        public string UpdateCompany(BizCompany bizCompany)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdCompany(
                                     bizCompany.Id,
                                     bizCompany.CompanyName
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="bizUser">The biz user.</param>
        /// <returns>System.String.</returns>
        public string UpdateUser(BizUser bizUser)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdUser(
                                     bizUser.Id,
                                     bizUser.TypeId,
                                     bizUser.UserName,
                                     bizUser.UserMiddleName,
                                     bizUser.UserLastName,
                                     bizUser.UserMotherName,
                                     bizUser.Email
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the vehicle.
        /// </summary>
        /// <param name="bizVehicle">The biz vehicle.</param>
        /// <returns>System.String.</returns>
        public string UpdateVehicle(BizVehicle bizVehicle)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdVehicle(
                                      bizVehicle.Id,
                                      bizVehicle.Plates
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the address.
        /// </summary>
        /// <param name="bizAddress">The biz address.</param>
        /// <returns>System.String.</returns>
        public string UpdateAddress(BizAddress bizAddress)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdAddress(
                                     bizAddress.Id,
                                     bizAddress.StreetName,
                                     bizAddress.Number,
                                     bizAddress.PostalCode
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the committee member.
        /// </summary>
        /// <param name="bizCommitteeMember">The biz committee member.</param>
        /// <returns>System.String.</returns>
        public string UpdateCommitteeMember(BizCommitteeMember bizCommitteeMember)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdCommitteeMember(
                                     bizCommitteeMember.Id,
                                     bizCommitteeMember.CommitteeTypeId
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the event.
        /// </summary>
        /// <param name="bizEvent">The biz event.</param>
        /// <returns>System.String.</returns>
        public string UpdateEvent(BizEvent bizEvent)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdEvent(
                                     bizEvent.Id,
                                     bizEvent.Status,
                                     bizEvent.RecreationalAreaId,
                                     bizEvent.StartDate,
                                     bizEvent.EndDate
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the ticket.
        /// </summary>
        /// <param name="bizTicket">The biz ticket.</param>
        /// <returns>System.String.</returns>
        public string UpdateTicket(BizTicket bizTicket)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdTicket(
                                      bizTicket.Id,
                                      bizTicket.StatusId
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the visit.
        /// </summary>
        /// <param name="bizVisit">The biz visit.</param>
        /// <returns>System.String.</returns>
        public string UpdateVisit(BizVisit bizVisit)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdVisit(
                                      bizVisit.Carnet
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the assist control.
        /// </summary>
        /// <param name="bizAssistControl">The biz assist control.</param>
        /// <returns>System.String.</returns>
        public string UpdateAssistControl(BizAssistControl bizAssistControl)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdAssistControl(
                                      bizAssistControl.UserId
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Updates the payment.
        /// </summary>
        /// <param name="bizPayment">The biz payment.</param>
        /// <returns>System.String.</returns>
        public string UpdatePayment(BizPayment bizPayment)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdPayment(
                                      bizPayment.Id,
                                      bizPayment.PaymentStatus
                        );
                }
                )
            );
            return Result;
        }

        #endregion

        #region GET

        /// <summary>
        /// Gets the type user.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizTypeUser&gt;.</returns>
        public List<BizTypeUser> GetTypeUser(int? Id = null, bool? Active = null)
        {
            List<BizTypeUser> bizUser = new List<BizTypeUser>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetCatTypeUser(Id);
                    foreach (var data in result)
                    {
                        bizUser.Add(data.DataTypeUserToBizTypeUser());
                    }
                }
                )
            );
            return bizUser;
        }

        /// <summary>
        /// Gets the type committee.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizTypeCommittee&gt;.</returns>
        public List<BizTypeCommittee> GetTypeCommittee(int? Id = null, bool? Active = null)
        {
            List<BizTypeCommittee> bizTypeCommittee = new List<BizTypeCommittee>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetCatTypeCommittee(Id);
                    foreach (var data in result)
                    {
                        bizTypeCommittee.Add(data.DataTypeCommitteeToBizTypeCommittee());
                    }
                }
                )
            );
            return bizTypeCommittee;
        }

        /// <summary>
        /// Gets the type visit.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizTypeVisit&gt;.</returns>
        public List<BizTypeVisit> GetTypeVisit(int? Id = null, bool? Active = null)
        {
            List<BizTypeVisit> bizTypeVisit = new List<BizTypeVisit>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetCatTypeVisit(Id);
                    foreach (var data in result)
                    {
                        bizTypeVisit.Add(data.DataTypeVisitToBizTypeVisit());
                    }
                }
                )
            );
            return bizTypeVisit;
        }

        /// <summary>
        /// Gets the recreational area.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizRecreationalArea&gt;.</returns>
        public List<BizRecreationalArea> GetRecreationalArea(int? Id = null, bool? Active = null)
        {
            List<BizRecreationalArea> bizRecreationalArea = new List<BizRecreationalArea>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetCatRecreationalArea(Id);
                    foreach (var data in result)
                    {
                        bizRecreationalArea.Add(data.DataRecreationalAreaToBizRecreationalArea());
                    }
                }
                )
            );
            return bizRecreationalArea;
        }

        /// <summary>
        /// Gets the eventuality.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizEventuality&gt;.</returns>
        public List<BizEventuality> GetEventuality(int? Id = null, bool? Active = null)
        {
            List<BizEventuality> bizEventuality = new List<BizEventuality>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetCatEventuality(Id);
                    foreach (var data in result)
                    {
                        bizEventuality.Add(data.DataEventualityToBizEventuality());
                    }
                }
                )
            );
            return bizEventuality;
        }

        /// <summary>
        /// Gets the ticket status.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizTicketStatus&gt;.</returns>
        public List<BizTicketStatus> GetTicketStatus(int? Id = null, bool? Active = null)
        {
            List<BizTicketStatus> biziTicketStatus = new List<BizTicketStatus>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetCatTicketStatus(Id);
                    foreach (var data in result)
                    {
                        biziTicketStatus.Add(data.DataTicketStatusToBizTicketStatus());
                    }
                }
                )
            );
            return biziTicketStatus;
        }

        /// <summary>
        /// Gets the payment status.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizPaymentStatus&gt;.</returns>
        public List<BizPaymentStatus> GetPaymentStatus(int? Id = null, bool? Active = null)
        {
            List<BizPaymentStatus> biziPaymentStatus = new List<BizPaymentStatus>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetCatPaymentStatus(Id);
                    foreach (var data in result)
                    {
                        biziPaymentStatus.Add(data.DataPaymentStatusToBizPaymentStatus());
                    }
                }
                )
            );
            return biziPaymentStatus;
        }

        /// <summary>
        /// Gets the event status.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizEventStatus&gt;.</returns>
        public List<BizEventStatus> GetEventStatus(int? Id = null, bool? Active = null)
        {
            List<BizEventStatus> bizEventStatus = new List<BizEventStatus>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetCatEventStatus(Id);
                    foreach (var data in result)
                    {
                        bizEventStatus.Add(data.DataEventStatusToBizEventStatus());
                    }
                }
                )
            );
            return bizEventStatus;
        }

        /// <summary>
        /// Gets the supplier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizSupplier&gt;.</returns>
        public List<BizSupplier> GetSupplier(int? Id = null, bool? Active = null)
        {
            List<BizSupplier> bizSupplier = new List<BizSupplier>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetCatSupplier(Id);
                    foreach (var data in result)
                    {
                        bizSupplier.Add(data.DataSupplierToBizSupplier());
                    }
                }
                )
            );
            return bizSupplier;
        }

        /// <summary>
        /// Gets the company.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizCompany&gt;.</returns>
        public List<BizCompany> GetCompany(int? Id = null, bool? Active = null)
        {
            List<BizCompany> bizCompany = new List<BizCompany>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetCompany(Id);
                    foreach (var data in result)
                    {
                        bizCompany.Add(data.DataCompanyToBizCompany());
                    }
                }
                )
            );
            return bizCompany;
        }

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizUser&gt;.</returns>
        public List<BizUser> GetUser(int? Id = null, bool? Active = null)
        {
            List<BizUser> bizUser = new List<BizUser>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetUser(Id, Active);
                    foreach (var data in result)
                    {
                        bizUser.Add(data.DataUserToBizUser());
                    }
                }
                )
            );
            return bizUser;
        }

        /// <summary>
        /// Gets the vehicle.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizVehicle&gt;.</returns>
        public List<BizVehicle> GetVehicle(int? Id = null, bool? Active = null)
        {
            List<BizVehicle> bizVehicle = new List<BizVehicle>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetVehicle(Id, Active);
                    foreach (var data in result)
                    {
                        bizVehicle.Add(data.DataVehicleToBizVehicle());
                    }
                }
                )
            );
            return bizVehicle;
        }

        /// <summary>
        /// Gets the address.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizAddress&gt;.</returns>
        public List<BizAddress> GetAddress(int? Id = null, bool? Active = null)
        {
            List<BizAddress> bizAddress = new List<BizAddress>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetAddress(Id);
                    foreach (var data in result)
                    {
                        bizAddress.Add(data.DataAddressToBizAddress());
                    }
                }
                )
            );
            return bizAddress;
        }

        /// <summary>
        /// Gets the committee member.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizCommitteeMember&gt;.</returns>
        public List<BizCommitteeMember> GetCommitteeMember(int? Id = null, bool? Active = null)
        {
            List<BizCommitteeMember> bizCommitteeMember = new List<BizCommitteeMember>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetCommitteeMember(Id);
                    foreach (var data in result)
                    {
                        bizCommitteeMember.Add(data.DataCommitteeMemberToBizCommitteeMember());
                    }
                }
                )
            );
            return bizCommitteeMember;
        }

        /// <summary>
        /// Gets the event.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizEvent&gt;.</returns>
        public List<BizEvent> GetEvent(int? Id = null, bool? Active = null)
        {
            List<BizEvent> bizEvent = new List<BizEvent>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetEvent(Id);
                    foreach (var data in result)
                    {
                        bizEvent.Add(data.DataEventToBizEvent());
                    }
                }
                )
            );
            return bizEvent;
        }

        /// <summary>
        /// Gets the ticket.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizTicket&gt;.</returns>
        public List<BizTicket> GetTicket(int? Id = null, bool? Active = null)
        {
            List<BizTicket> bizTicket = new List<BizTicket>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetTicket(Id);
                    foreach (var data in result)
                    {
                        bizTicket.Add(data.DataTicketToBizTicket());
                    }
                }
                )
            );
            return bizTicket;
        }

        /// <summary>
        /// Gets the visit.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizVisit&gt;.</returns>
        public List<BizVisit> GetVisit(int? Id = null, bool? Active = null)
        {
            List<BizVisit> bizVisit = new List<BizVisit>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetVisit(Id);
                    foreach (var data in result)
                    {
                        bizVisit.Add(data.DataVisitToBizVisit());
                    }
                }
                )
            );
            return bizVisit;
        }

        /// <summary>
        /// Gets the assist control.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizAssistControl&gt;.</returns>
        public List<BizAssistControl> GetAssistControl(int? Id = null, bool? Active = null)
        {
            List<BizAssistControl> bizAssistControl = new List<BizAssistControl>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetAssistControl(Id);
                    foreach (var data in result)
                    {
                        bizAssistControl.Add(data.DataAssistControlToBizAssistControl());
                    }
                }
                )
            );
            return bizAssistControl;
        }

        /// <summary>
        /// Gets the payment.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizPayment&gt;.</returns>
        public List<BizPayment> GetPayment(int? Id = null, bool? Active = null)
        {
            List<BizPayment> bizPayment = new List<BizPayment>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetPayment(Id);
                    foreach (var data in result)
                    {
                        bizPayment.Add(data.DataPaymentToBizPayment());
                    }
                }
                )
            );
            return bizPayment;
        }

        /// <summary>
        /// Gets the internal box.
        /// </summary>
        /// <param name="Amount">The amount.</param>
        /// <param name="CreationDate">The creation date.</param>
        /// <returns>List&lt;BizInternalBox&gt;.</returns>
        public List<BizInternalBox> GetInternalBox(decimal? Amount, DateTime? CreationDate)
        {
            List<BizInternalBox> bizInternalBox = new List<BizInternalBox>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetInternalBox(Amount, CreationDate);
                    foreach (var data in result)
                    {
                        bizInternalBox.Add(data.DataInternalBoxToBizInternalBox());
                    }
                }
                )
            );

            return bizInternalBox;
        }

        /// <summary>
        /// Gets the internal expense.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizInternalExpense&gt;.</returns>
        public List<BizInternalExpense> GetInternalExpense(int? Id = null, bool? Active = null)
        {
            List<BizInternalExpense> bizInternalExpense = new List<BizInternalExpense>();
            BizCall(
                new Action(() =>
                {
                    var result = dbContext.SYSGetInternalExpense(Id);
                    foreach (var data in result)
                    {
                        bizInternalExpense.Add(data.DataInternalExpenseToBizInternalExpense());
                    }
                }
                )
            );

            return bizInternalExpense;
        }

        #endregion

        #region DELETE

        /// <summary>
        /// Deletes the type user.
        /// </summary>
        /// <param name="bizTypeUser">The biz type user.</param>
        /// <returns>System.String.</returns>
        public string DeleteTypeUser(BizTypeUser bizTypeUser)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSDelCatTypeUser(
                                     bizTypeUser.Id
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Deletes the type committee.
        /// </summary>
        /// <param name="bizTypeCommittee">The biz type committee.</param>
        /// <returns>System.String.</returns>
        public string DeleteTypeCommittee(BizTypeCommittee bizTypeCommittee)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSDelCatTypeCommittee(
                                     bizTypeCommittee.Id
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Deletes the type visit.
        /// </summary>
        /// <param name="bizTypeVisit">The biz type visit.</param>
        /// <returns>System.String.</returns>
        public string DeleteTypeVisit(BizTypeVisit bizTypeVisit)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSDelCatTypeVisit(
                                     bizTypeVisit.Id
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Deletes the recreational area.
        /// </summary>
        /// <param name="bizRecreationalArea">The biz recreational area.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public string DeleteRecreationalArea(BizRecreationalArea bizRecreationalArea)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the eventuality.
        /// </summary>
        /// <param name="bizEventuality">The biz eventuality.</param>
        /// <returns>System.String.</returns>
        public string DeleteEventuality(BizEventuality bizEventuality)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSDelCatEventuality(
                                      bizEventuality.Id
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Deletes the ticket status.
        /// </summary>
        /// <param name="bizTicketStatus">The biz ticket status.</param>
        /// <returns>System.String.</returns>
        public string DeleteTicketStatus(BizTicketStatus bizTicketStatus)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSDelCatTicketStatus(
                                      bizTicketStatus.Id
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Deletes the payment status.
        /// </summary>
        /// <param name="bizPaymentStatus">The biz payment status.</param>
        /// <returns>System.String.</returns>
        public string DeletePaymentStatus(BizPaymentStatus bizPaymentStatus)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSDelCatPaymentStatus(
                                      bizPaymentStatus.Id
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Deletes the event status.
        /// </summary>
        /// <param name="bizEventStatus">The biz event status.</param>
        /// <returns>System.String.</returns>
        public string DeleteEventStatus(BizEventStatus bizEventStatus)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSDelCatEventStatus(
                                      bizEventStatus.Id
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Deletes the supplier.
        /// </summary>
        /// <param name="bizSupplier">The biz supplier.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public string DeleteSupplier(BizSupplier bizSupplier)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the company.
        /// </summary>
        /// <param name="bizCompany">The biz company.</param>
        /// <returns>System.String.</returns>
        public string DeleteCompany(BizCompany bizCompany)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSDelCompany(
                                      bizCompany.Id
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="bizUser">The biz user.</param>
        /// <returns>System.String.</returns>
        public string DeleteUser(BizUser bizUser)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSDelUser(
                                      bizUser.Id
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Deletes the vehicle.
        /// </summary>
        /// <param name="bizVehicle">The biz vehicle.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public string DeleteVehicle(BizVehicle bizVehicle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the address.
        /// </summary>
        /// <param name="bizAddress">The biz address.</param>
        /// <returns>System.String.</returns>
        public string DeleteAddress(BizAddress bizAddress)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSDelAddress(
                                      bizAddress.Id
                        );
                }
                )
            );
            return Result;
        }

        /// <summary>
        /// Deletes the committee member.
        /// </summary>
        /// <param name="bizCommitteeMember">The biz committee member.</param>
        /// <returns>System.String.</returns>
        public string DeleteCommitteeMember(BizCommitteeMember bizCommitteeMember)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSDelCommitteeMember(
                                      bizCommitteeMember.Id
                        );
                }
                )
            );
            return Result;
        }

        #endregion

    }
}
