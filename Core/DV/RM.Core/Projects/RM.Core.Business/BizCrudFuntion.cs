using PasswordSecurity;
using RM.Core.Business.Biz;
using RM.Core.Business.Entities.Views;
using RM.Core.Data.Implementation;
using System;
using System.Collections.Generic;

namespace RM.Core.Business
{
    public class BizCrudFuntion: BizLogic
    {
        private CrudFuntion crudFuntion = new CrudFuntion();

        #region INSERT

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
