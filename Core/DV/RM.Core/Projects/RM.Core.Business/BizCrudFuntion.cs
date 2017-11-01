using PasswordSecurity;
using RM.Core.Business.Biz;
using RM.Core.Business.Entities.Views;
using RM.Core.Data.Implementation;
using System;

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
        #endregion

        #region GET
        #endregion

        #region DELETE
        #endregion
    }
}
