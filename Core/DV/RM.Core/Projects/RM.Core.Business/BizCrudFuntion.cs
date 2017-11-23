using PasswordSecurity;
using RM.Core.Business.Biz;
using RM.Core.Business.Entities.Views;
using RM.Core.Data.Implementation;
using System;
using System.Collections.Generic;

namespace RM.Core.Business
{
    /// <summary>
    /// Class BizCrudFuntion.
    /// </summary>
    /// <seealso cref="RM.Core.Business.Biz.BizLogic" />
    public class BizCrudFuntion: BizLogic
    {
        /// <summary>
        /// The crud funtion
        /// </summary>
        private CrudFuntion crudFuntion = new CrudFuntion();

        #region INSERT

        /// <summary>
        /// Bizs the insert type user.
        /// </summary>
        /// <param name="bizTypeUser">The biz type user.</param>
        /// <returns>System.String.</returns>
        public string BizInsertTypeUser(BizTypeUser bizTypeUser)
        {
            return BizCall(
               new Action(() =>
               {
                   crudFuntion.InsertTypeUser(bizTypeUser);
               }
               )
           );
        }

        /// <summary>
        /// Bizs the insert type committee.
        /// </summary>
        /// <param name="bizTypeCommittee">The biz type committee.</param>
        /// <returns>System.String.</returns>
        public string BizInsertTypeCommittee(BizTypeCommittee bizTypeCommittee)
        {
            return BizCall(
               new Action(() =>
               {
                   crudFuntion.InsertTypeCommittee(bizTypeCommittee);
               }
               )
           );
        }

        /// <summary>
        /// Bizs the insert type visit.
        /// </summary>
        /// <param name="bizTypeVisit">The biz type visit.</param>
        /// <returns>System.String.</returns>
        public string BizInsertTypeVisit(BizTypeVisit bizTypeVisit)
        {
            return BizCall(
               new Action(() =>
               {
                   crudFuntion.InsertTypeVisit(bizTypeVisit);
               }
               )
           );
        }

        /// <summary>
        /// Bizs the insert recreational area.
        /// </summary>
        /// <param name="bizRecreationalArea">The biz recreational area.</param>
        /// <returns>System.String.</returns>
        public string BizInsertRecreationalArea(BizRecreationalArea bizRecreationalArea)
        {
            return BizCall(
               new Action(() =>
               {
                   crudFuntion.InsertRecreationalArea(bizRecreationalArea);
               }
               )
           );
        }

        /// <summary>
        /// Bizs the insert eventuality.
        /// </summary>
        /// <param name="bizEventuality">The biz eventuality.</param>
        /// <returns>System.String.</returns>
        public string BizInsertEventuality(BizEventuality bizEventuality)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertEventuality(bizEventuality);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the insert ticket status.
        /// </summary>
        /// <param name="bizTicketStatus">The biz ticket status.</param>
        /// <returns>System.String.</returns>
        public string BizInsertTicketStatus(BizTicketStatus bizTicketStatus)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertTicketStatus(bizTicketStatus);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the insert payment status.
        /// </summary>
        /// <param name="bizPaymentStatus">The biz payment status.</param>
        /// <returns>System.String.</returns>
        public string BizInsertPaymentStatus(BizPaymentStatus bizPaymentStatus)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertPaymentStatus(bizPaymentStatus);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the insert event status.
        /// </summary>
        /// <param name="bizEventStatus">The biz event status.</param>
        /// <returns>System.String.</returns>
        public string BizInsertEventStatus(BizEventStatus bizEventStatus)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertEventStatus(bizEventStatus);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the insert supplier.
        /// </summary>
        /// <param name="bizSupplier">The biz supplier.</param>
        /// <returns>System.String.</returns>
        public string BizInsertSupplier(BizSupplier bizSupplier)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertSupplier(bizSupplier);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the insert company.
        /// </summary>
        /// <param name="bizCompany">The biz company.</param>
        /// <returns>System.String.</returns>
        public string BizInsertCompany(BizCompany bizCompany)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertCompany(bizCompany);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the insert user.
        /// </summary>
        /// <param name="bizUser">The biz user.</param>
        /// <returns>System.String.</returns>
        public string BizInsertUser(BizUser bizUser)
        {
            bizUser.PassWord = PasswordStorage.CreateHash(bizUser.PassWord);
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertUser(bizUser);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the insert vehicle.
        /// </summary>
        /// <param name="bizVehicle">The biz vehicle.</param>
        /// <returns>System.String.</returns>
        public string BizInsertVehicle(BizVehicle bizVehicle)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertVehicle(bizVehicle);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the insert address.
        /// </summary>
        /// <param name="bizAddress">The biz address.</param>
        /// <returns>System.String.</returns>
        public string BizInsertAddress(BizAddress bizAddress)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertAddress(bizAddress);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the insert committee member.
        /// </summary>
        /// <param name="bizCommitteeMember">The biz committee member.</param>
        /// <returns>System.String.</returns>
        public string BizInsertCommitteeMember(BizCommitteeMember bizCommitteeMember)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertCommitteeMember(bizCommitteeMember);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the insert event.
        /// </summary>
        /// <param name="bizEvent">The biz event.</param>
        /// <returns>System.String.</returns>
        public string BizInsertEvent(BizEvent bizEvent)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertEvent(bizEvent);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the insert ticket.
        /// </summary>
        /// <param name="bizTicket">The biz ticket.</param>
        /// <returns>System.String.</returns>
        public string BizInsertTicket(BizTicket bizTicket)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertTicket(bizTicket);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the insert visit.
        /// </summary>
        /// <param name="bizVisit">The biz visit.</param>
        /// <returns>System.String.</returns>
        public string BizInsertVisit(BizVisit bizVisit)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertVisit(bizVisit);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the insert assist control.
        /// </summary>
        /// <param name="bizAssistControl">The biz assist control.</param>
        /// <returns>System.String.</returns>
        public string BizInsertAssistControl(BizAssistControl bizAssistControl)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertAssistControl(bizAssistControl);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the insert payment.
        /// </summary>
        /// <param name="bizPayment">The biz payment.</param>
        /// <returns>System.String.</returns>
        public string BizInsertPayment(BizPayment bizPayment)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertPayment(bizPayment);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the insert internal box.
        /// </summary>
        /// <param name="bizInternalBox">The biz internal box.</param>
        /// <returns>System.String.</returns>
        public string BizInsertInternalBox(BizInternalBox bizInternalBox)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertInternalBox(bizInternalBox);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the insert internal expense.
        /// </summary>
        /// <param name="bizInternalExpense">The biz internal expense.</param>
        /// <returns>System.String.</returns>
        public string BizInsertInternalExpense(BizInternalExpense bizInternalExpense)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.InsertInternalExpense(bizInternalExpense);
                }
                )
            );
        }

        #endregion

        #region UPDATE

        /// <summary>
        /// Bizs the update type user.
        /// </summary>
        /// <param name="bizTypeUser">The biz type user.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateTypeUser(BizTypeUser bizTypeUser)
        {
            return BizCall(
               new Action(() =>
               {
                   crudFuntion.UpdateTypeUser(bizTypeUser);
               }
               )
           );
        }

        /// <summary>
        /// Bizs the update type committee.
        /// </summary>
        /// <param name="bizTypeCommittee">The biz type committee.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateTypeCommittee(BizTypeCommittee bizTypeCommittee)
        {
            return BizCall(
               new Action(() =>
               {
                   crudFuntion.UpdateTypeCommittee(bizTypeCommittee);
               }
               )
           );
        }

        /// <summary>
        /// Bizs the update type visit.
        /// </summary>
        /// <param name="bizTypeVisit">The biz type visit.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateTypeVisit(BizTypeVisit bizTypeVisit)
        {
            return BizCall(
               new Action(() =>
               {
                   crudFuntion.UpdateTypeVisit(bizTypeVisit);
               }
               )
           );
        }

        /// <summary>
        /// Bizs the update recreational area.
        /// </summary>
        /// <param name="bizRecreationalArea">The biz recreational area.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateRecreationalArea(BizRecreationalArea bizRecreationalArea)
        {
            return BizCall(
               new Action(() =>
               {
                   crudFuntion.UpdateRecreationalArea(bizRecreationalArea);
               }
               )
           );
        }

        /// <summary>
        /// Bizs the update eventuality.
        /// </summary>
        /// <param name="bizEventuality">The biz eventuality.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateEventuality(BizEventuality bizEventuality)
        {
            return BizCall(
               new Action(() =>
               {
                   crudFuntion.UpdateEventuality(bizEventuality);
               }
               )
           );
        }

        /// <summary>
        /// Bizs the update ticket status.
        /// </summary>
        /// <param name="bizTicketStatus">The biz ticket status.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateTicketStatus(BizTicketStatus bizTicketStatus)
        {
            return BizCall(
              new Action(() =>
              {
                  crudFuntion.UpdateTicketStatus(bizTicketStatus);
              }
              )
          );
        }

        /// <summary>
        /// Bizs the update payment status.
        /// </summary>
        /// <param name="bizPaymentStatus">The biz payment status.</param>
        /// <returns>System.String.</returns>
        public string BizUpdatePaymentStatus(BizPaymentStatus bizPaymentStatus)
        {
            return BizCall(
               new Action(() =>
               {
                   crudFuntion.UpdatePaymentStatus(bizPaymentStatus);
               }
               )
           );
        }

        /// <summary>
        /// Bizs the update event status.
        /// </summary>
        /// <param name="bizEventStatus">The biz event status.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateEventStatus(BizEventStatus bizEventStatus)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.UpdateEventStatus(bizEventStatus);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the update supplier.
        /// </summary>
        /// <param name="bizSupplier">The biz supplier.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateSupplier(BizSupplier bizSupplier)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.UpdateSupplier(bizSupplier);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the update company.
        /// </summary>
        /// <param name="bizCompany">The biz company.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateCompany(BizCompany bizCompany)
        {
            return BizCall(
                 new Action(() =>
                 {
                     crudFuntion.UpdateCompany(bizCompany);
                 }
                 )
             );
        }

        /// <summary>
        /// Bizs the update user.
        /// </summary>
        /// <param name="bizUser">The biz user.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateUser(BizUser bizUser)
        {
            return BizCall(
                  new Action(() =>
                  {
                      crudFuntion.UpdateUser(bizUser);
                  }
                  )
              );
        }

        /// <summary>
        /// Bizs the update vehicle.
        /// </summary>
        /// <param name="bizVehicle">The biz vehicle.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateVehicle(BizVehicle bizVehicle)
        {
            return BizCall(
                  new Action(() =>
                  {
                      crudFuntion.UpdateVehicle(bizVehicle);
                  }
                  )
              );
        }

        /// <summary>
        /// Bizs the update address.
        /// </summary>
        /// <param name="bizAddress">The biz address.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateAddress(BizAddress bizAddress)
        {
            return BizCall(
                  new Action(() =>
                  {
                      crudFuntion.UpdateAddress(bizAddress);
                  }
                  )
              );
        }

        /// <summary>
        /// Bizs the update committee member.
        /// </summary>
        /// <param name="bizCommitteeMember">The biz committee member.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateCommitteeMember(BizCommitteeMember bizCommitteeMember)
        {
            return BizCall(
                   new Action(() =>
                   {
                       crudFuntion.UpdateCommitteeMember(bizCommitteeMember);
                   }
                   )
            );
        }

        /// <summary>
        /// Bizs the update event.
        /// </summary>
        /// <param name="bizEvent">The biz event.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateEvent(BizEvent bizEvent)
        {
            return BizCall(
                   new Action(() =>
                   {
                       crudFuntion.UpdateEvent(bizEvent);
                   }
                   )
            );
        }

        /// <summary>
        /// Bizs the update ticket.
        /// </summary>
        /// <param name="bizTicket">The biz ticket.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateTicket(BizTicket bizTicket)
        {
            return BizCall(
                   new Action(() =>
                   {
                       crudFuntion.UpdateTicket(bizTicket);
                   }
                   )
            );
        }

        /// <summary>
        /// Bizs the update visit.
        /// </summary>
        /// <param name="bizVisit">The biz visit.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateVisit(BizVisit bizVisit)
        {
            return BizCall(
                   new Action(() =>
                   {
                       crudFuntion.UpdateVisit(bizVisit);
                   }
                   )
            );
        }

        /// <summary>
        /// Bizs the update assist control.
        /// </summary>
        /// <param name="bizAssistControl">The biz assist control.</param>
        /// <returns>System.String.</returns>
        public string BizUpdateAssistControl(BizAssistControl bizAssistControl)
        {
            return BizCall(
                   new Action(() =>
                   {
                       crudFuntion.UpdateAssistControl(bizAssistControl);
                   }
                   )
            );
        }

        /// <summary>
        /// Bizs the update payment.
        /// </summary>
        /// <param name="bizPayment">The biz payment.</param>
        /// <returns>System.String.</returns>
        public string BizUpdatePayment(BizPayment bizPayment)
        {
            return BizCall(
                   new Action(() =>
                   {
                       crudFuntion.UpdatePayment(bizPayment);
                   }
                   )
            );
        }

        #endregion

        #region GET

        /// <summary>
        /// Bizs the get type user.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizTypeUser&gt;.</returns>
        public List<BizTypeUser> BizGetTypeUser(int? Id = null, bool? Active = null)
        {
            List<BizTypeUser> bizTypeUser = new List<BizTypeUser>();
            BizCall(
                new Action(() =>
                {
                    bizTypeUser = crudFuntion.GetTypeUser(Id, Active);
                }
                )
            );
            return bizTypeUser;
        }

        /// <summary>
        /// Bizs the get type committee.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizTypeCommittee&gt;.</returns>
        public List<BizTypeCommittee> BizGetTypeCommittee(int? Id = null, bool? Active = null)
        {
            List<BizTypeCommittee> bizTypeCommittee = new List<BizTypeCommittee>();
            BizCall(
                new Action(() =>
                {
                    bizTypeCommittee = crudFuntion.GetTypeCommittee(Id, Active);
                }
                )
            );
            return bizTypeCommittee;
        }

        /// <summary>
        /// Bizs the get type visit.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizTypeVisit&gt;.</returns>
        public List<BizTypeVisit> BizGetTypeVisit(int? Id = null, bool? Active = null)
        {
            List<BizTypeVisit> bizTypeVisit = new List<BizTypeVisit>();
            BizCall(
                new Action(() =>
                {
                    bizTypeVisit = crudFuntion.GetTypeVisit(Id, Active);
                }
                )
            );
            return bizTypeVisit;
        }

        /// <summary>
        /// Bizs the get recreational area.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizRecreationalArea&gt;.</returns>
        public List<BizRecreationalArea> BizGetRecreationalArea(int? Id = null, bool? Active = null)
        {
            List<BizRecreationalArea> bizRecreationalArea = new List<BizRecreationalArea>();
            BizCall(
                new Action(() =>
                {
                    bizRecreationalArea = crudFuntion.GetRecreationalArea(Id, Active);
                }
                )
            );
            return bizRecreationalArea;
        }

        /// <summary>
        /// Bizs the get eventuality.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizEventuality&gt;.</returns>
        public List<BizEventuality> BizGetEventuality(int? Id = null, bool? Active = null)
        {
            List<BizEventuality> bizEventuality = new List<BizEventuality>();
            BizCall(
                new Action(() =>
                {
                    bizEventuality = crudFuntion.GetEventuality(Id, Active);
                }
                )
            );
            return bizEventuality;
        }

        /// <summary>
        /// Bizs the get ticket status.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizTicketStatus&gt;.</returns>
        public List<BizTicketStatus> BizGetTicketStatus(int? Id = null, bool? Active = null)
        {
            List<BizTicketStatus> biziTicketStatus = new List<BizTicketStatus>();
            BizCall(
                new Action(() =>
                {
                    biziTicketStatus = crudFuntion.GetTicketStatus(Id, Active);
                }
                )
            );
            return biziTicketStatus;
        }

        /// <summary>
        /// Bizs the get payment status.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizPaymentStatus&gt;.</returns>
        public List<BizPaymentStatus> BizGetPaymentStatus(int? Id = null, bool? Active = null)
        {
            List<BizPaymentStatus> biziPaymentStatus = new List<BizPaymentStatus>();
            BizCall(
                new Action(() =>
                {
                    biziPaymentStatus = crudFuntion.GetPaymentStatus(Id, Active);
                }
                )
            );
            return biziPaymentStatus;
        }

        /// <summary>
        /// Bizs the get event status.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizEventStatus&gt;.</returns>
        public List<BizEventStatus> BizGetEventStatus(int? Id = null, bool? Active = null)
        {
            List<BizEventStatus> bizEventStatus = new List<BizEventStatus>();
            BizCall(
                new Action(() =>
                {
                    bizEventStatus = crudFuntion.GetEventStatus(Id, Active);
                }
                )
            );
            return bizEventStatus;
        }

        /// <summary>
        /// Bizs the get supplier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizSupplier&gt;.</returns>
        public List<BizSupplier> BizGetSupplier(int? Id = null, bool? Active = null)
        {
            List<BizSupplier> bizSupplier = new List<BizSupplier>();
            BizCall(
                new Action(() =>
                {
                    bizSupplier = crudFuntion.GetSupplier(Id, Active);
                }
                )
            );
            return bizSupplier;
        }

        /// <summary>
        /// Bizs the get company.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizCompany&gt;.</returns>
        public List<BizCompany> BizGetCompany(int? Id = null, bool? Active = null)
        {
            List<BizCompany> bizCompany = new List<BizCompany>();
            BizCall(
                new Action(() =>
                {
                    bizCompany = crudFuntion.GetCompany(Id, Active);
                }
                )
            );
            return bizCompany;
        }

        /// <summary>
        /// Bizs the get user.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizUser&gt;.</returns>
        public List<BizUser> BizGetUser(int? Id = null, bool? Active = null)
        {
            List<BizUser> bizUser = new List<BizUser>();
            BizCall(
                new Action(() =>
                {
                    bizUser = crudFuntion.GetUser(Id, Active);
                }
                )
            );
            return bizUser;
        }

        /// <summary>
        /// Bizs the get vehicle.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizVehicle&gt;.</returns>
        public List<BizVehicle> BizGetVehicle(int? Id = null, bool? Active = null)
        {
            List<BizVehicle> bizVehicle = new List<BizVehicle>();
            BizCall(
                new Action(() =>
                {
                    bizVehicle = crudFuntion.GetVehicle(Id, Active);
                }
                )
            );
            return bizVehicle;
        }

        /// <summary>
        /// Bizs the get address.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizAddress&gt;.</returns>
        public List<BizAddress> BizGetAddress(int? Id = null, bool? Active = null)
        {
            List<BizAddress> bizAddress = new List<BizAddress>();
            BizCall(
                new Action(() =>
                {
                    bizAddress = crudFuntion.GetAddress(Id, Active);
                }
                )
            );
            return bizAddress;
        }

        /// <summary>
        /// Bizs the get committee member.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizCommitteeMember&gt;.</returns>
        public List<BizCommitteeMember> BizGetCommitteeMember(int? Id = null, bool? Active = null)
        {
            List<BizCommitteeMember> bizCommitteeMember = new List<BizCommitteeMember>();
            BizCall(
                new Action(() =>
                {
                    bizCommitteeMember = crudFuntion.GetCommitteeMember(Id, Active);
                }
                )
            );
            return bizCommitteeMember;
        }

        /// <summary>
        /// Bizs the get event.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizEvent&gt;.</returns>
        public List<BizEvent> BizGetEvent(int? Id = null, bool? Active = null)
        {
            List<BizEvent> bizEvent = new List<BizEvent>();
            BizCall(
                new Action(() =>
                {
                    bizEvent = crudFuntion.GetEvent(Id, Active);
                }
                )
            );
            return bizEvent;
        }

        /// <summary>
        /// Bizs the get ticket.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizTicket&gt;.</returns>
        public List<BizTicket> BizGetTicket(int? Id = null, bool? Active = null)
        {
            List<BizTicket> bizTicket = new List<BizTicket>();
            BizCall(
                new Action(() =>
                {
                    bizTicket = crudFuntion.GetTicket(Id, Active);
                }
                )
            );
            return bizTicket;
        }

        /// <summary>
        /// Bizs the get visit.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizVisit&gt;.</returns>
        public List<BizVisit> BizGetVisit(int? Id = null, bool? Active = null)
        {
            List<BizVisit> bizVisit = new List<BizVisit>();
            BizCall(
                new Action(() =>
                {
                    bizVisit = crudFuntion.GetVisit(Id, Active);
                }
                )
            );
            return bizVisit;
        }

        /// <summary>
        /// Bizs the get assist control.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizAssistControl&gt;.</returns>
        public List<BizAssistControl> BizGetAssistControl(int? Id = null, bool? Active = null)
        {
            List<BizAssistControl> bizAssistControl = new List<BizAssistControl>();
            BizCall(
                new Action(() =>
                {
                    bizAssistControl = crudFuntion.GetAssistControl(Id, Active);
                }
                )
            );
            return bizAssistControl;
        }

        /// <summary>
        /// Bizs the get payment.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizPayment&gt;.</returns>
        public List<BizPayment> BizGetPayment(int? Id = null, bool? Active = null)
        {
            List<BizPayment> bizPayment = new List<BizPayment>();
            BizCall(
                new Action(() =>
                {
                    bizPayment = crudFuntion.GetPayment(Id, Active);
                }
                )
            );
            return bizPayment;
        }

        /// <summary>
        /// Bizs the get internal box.
        /// </summary>
        /// <param name="Amount">The amount.</param>
        /// <param name="CreationDate">The creation date.</param>
        /// <returns>List&lt;BizInternalBox&gt;.</returns>
        public List<BizInternalBox> BizGetInternalBox(decimal? Amount, DateTime? CreationDate)
        {
            List<BizInternalBox> bizInternalBox = new List<BizInternalBox>();
            BizCall(
                new Action(() =>
                {
                    bizInternalBox = crudFuntion.GetInternalBox(Amount, CreationDate);
                }
                )
            );

            return bizInternalBox;
        }

        /// <summary>
        /// Bizs the get internal expense.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Active">if set to <c>true</c> [active].</param>
        /// <returns>List&lt;BizInternalExpense&gt;.</returns>
        public List<BizInternalExpense> BizGetInternalExpense(int? Id = null, bool? Active = null)
        {
            List<BizInternalExpense> bizInternalExpense = new List<BizInternalExpense>();
            BizCall(
                new Action(() =>
                {
                    bizInternalExpense = crudFuntion.GetInternalExpense(Id, Active);
                }
                )
            );

            return bizInternalExpense;
        }

        #endregion

        #region DELETE

        /// <summary>
        /// Bizs the delete type user.
        /// </summary>
        /// <param name="bizTypeUser">The biz type user.</param>
        /// <returns>System.String.</returns>
        public string BizDeleteTypeUser(BizTypeUser bizTypeUser)
        {
            return BizCall(
               new Action(() =>
               {
                   crudFuntion.DeleteTypeUser(bizTypeUser);
               }
               )
           );
        }

        /// <summary>
        /// Bizs the delete type committee.
        /// </summary>
        /// <param name="bizTypeCommittee">The biz type committee.</param>
        /// <returns>System.String.</returns>
        public string BizDeleteTypeCommittee(BizTypeCommittee bizTypeCommittee)
        {
            return BizCall(
               new Action(() =>
               {
                   crudFuntion.DeleteTypeCommittee(bizTypeCommittee);
               }
               )
           );
        }

        /// <summary>
        /// Bizs the delete type visit.
        /// </summary>
        /// <param name="bizTypeVisit">The biz type visit.</param>
        /// <returns>System.String.</returns>
        public string BizDeleteTypeVisit(BizTypeVisit bizTypeVisit)
        {
            return BizCall(
               new Action(() =>
               {
                   crudFuntion.DeleteTypeVisit(bizTypeVisit);
               }
               )
           );
        }

        /// <summary>
        /// Bizs the delete recreational area.
        /// </summary>
        /// <param name="bizRecreationalArea">The biz recreational area.</param>
        /// <returns>System.String.</returns>
        public string BizDeleteRecreationalArea(BizRecreationalArea bizRecreationalArea)
        {
            return BizCall(
               new Action(() =>
               {
                   crudFuntion.DeleteRecreationalArea(bizRecreationalArea);
               }
               )
           );
        }

        /// <summary>
        /// Bizs the delete eventuality.
        /// </summary>
        /// <param name="bizEventuality">The biz eventuality.</param>
        /// <returns>System.String.</returns>
        public string BizDeleteEventuality(BizEventuality bizEventuality)
        {
            return BizCall(
               new Action(() =>
               {
                   crudFuntion.DeleteEventuality(bizEventuality);
               }
               )
           );
        }

        /// <summary>
        /// Bizs the delete ticket status.
        /// </summary>
        /// <param name="bizTicketStatus">The biz ticket status.</param>
        /// <returns>System.String.</returns>
        public string BizDeleteTicketStatus(BizTicketStatus bizTicketStatus)
        {
            return BizCall(
              new Action(() =>
              {
                  crudFuntion.DeleteTicketStatus(bizTicketStatus);
              }
              )
          );
        }

        /// <summary>
        /// Bizs the delete payment status.
        /// </summary>
        /// <param name="bizPaymentStatus">The biz payment status.</param>
        /// <returns>System.String.</returns>
        public string BizDeletePaymentStatus(BizPaymentStatus bizPaymentStatus)
        {
            return BizCall(
               new Action(() =>
               {
                   crudFuntion.DeletePaymentStatus(bizPaymentStatus);
               }
               )
           );
        }

        /// <summary>
        /// Bizs the delete event status.
        /// </summary>
        /// <param name="bizEventStatus">The biz event status.</param>
        /// <returns>System.String.</returns>
        public string BizDeleteEventStatus(BizEventStatus bizEventStatus)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.DeleteEventStatus(bizEventStatus);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the delete supplier.
        /// </summary>
        /// <param name="bizSupplier">The biz supplier.</param>
        /// <returns>System.String.</returns>
        public string BizDeleteSupplier(BizSupplier bizSupplier)
        {
            return BizCall(
                new Action(() =>
                {
                    crudFuntion.DeleteSupplier(bizSupplier);
                }
                )
            );
        }

        /// <summary>
        /// Bizs the delete company.
        /// </summary>
        /// <param name="bizCompany">The biz company.</param>
        /// <returns>System.String.</returns>
        public string BizDeleteCompany(BizCompany bizCompany)
        {
            return BizCall(
                 new Action(() =>
                 {
                     crudFuntion.DeleteCompany(bizCompany);
                 }
                 )
             );
        }

        /// <summary>
        /// Bizs the delete user.
        /// </summary>
        /// <param name="bizUser">The biz user.</param>
        /// <returns>System.String.</returns>
        public string BizDeleteUser(BizUser bizUser)
        {
            return BizCall(
                  new Action(() =>
                  {
                      crudFuntion.DeleteUser(bizUser);
                  }
                  )
              );
        }

        /// <summary>
        /// Bizs the delete vehicle.
        /// </summary>
        /// <param name="bizVehicle">The biz vehicle.</param>
        /// <returns>System.String.</returns>
        public string BizDeleteVehicle(BizVehicle bizVehicle)
        {
            return BizCall(
                  new Action(() =>
                  {
                      crudFuntion.DeleteVehicle(bizVehicle);
                  }
                  )
              );
        }

        /// <summary>
        /// Bizs the delete address.
        /// </summary>
        /// <param name="bizAddress">The biz address.</param>
        /// <returns>System.String.</returns>
        public string BizDeleteAddress(BizAddress bizAddress)
        {
            return BizCall(
                  new Action(() =>
                  {
                      crudFuntion.DeleteAddress(bizAddress);
                  }
                  )
              );
        }

        /// <summary>
        /// Bizs the delete committee member.
        /// </summary>
        /// <param name="bizCommitteeMember">The biz committee member.</param>
        /// <returns>System.String.</returns>
        public string BizDeleteCommitteeMember(BizCommitteeMember bizCommitteeMember)
        {
            return BizCall(
                   new Action(() =>
                   {
                       crudFuntion.DeleteCommitteeMember(bizCommitteeMember);
                   }
                   )
            );
        }

        #endregion
    }
}
