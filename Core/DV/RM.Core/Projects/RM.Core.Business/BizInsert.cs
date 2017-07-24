using RM.Core.Business.Biz;
using RM.Core.Business.Entities.Views;
using RM.Core.Data.Implementation;
using System;

namespace RM.Core.Business
{
    public class BizInsert: BizLogic
    {
        private Insert insert = new Insert();

        public string BizInsertTypeUser(BizTypeUser bizTypeUser)
        {
            return BizCall(
               new Action(() =>
               {
                   insert.InsertTypeUser(bizTypeUser);
               }
               )
           );
        }

        public string BizInsertTypeCommittee(BizTypeCommittee bizTypeCommittee)
        {
            return BizCall(
               new Action(() =>
               {
                   insert.InsertTypeCommittee(bizTypeCommittee);
               }
               )
           );
        }

        public string BizInsertTypeVisit(BizTypeVisit bizTypeVisit)
        {
            return BizCall(
               new Action(() =>
               {
                   insert.InsertTypeVisit(bizTypeVisit);
               }
               )
           );
        }

        public string BizInsertRecreationalArea(BizRecreationalArea bizRecreationalArea)
        {
            return BizCall(
               new Action(() =>
               {
                   insert.InsertRecreationalArea(bizRecreationalArea);
               }
               )
           );
        }

        public string BizInsertEventuality(BizEventuality bizEventuality)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertEventuality(bizEventuality);
                }
                )
            );
        }

        public string BizInsertTicketStatus(BizTicketStatus bizTicketStatus)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertTicketStatus(bizTicketStatus);
                }
                )
            );
        }

        public string BizInsertPaymentStatus(BizPaymentStatus bizPaymentStatus)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertPaymentStatus(bizPaymentStatus);
                }
                )
            );
        }

        public string BizInsertEventStatus(BizEventStatus bizEventStatus)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertEventStatus(bizEventStatus);
                }
                )
            );
        }

        public string BizInsertSupplier(BizSupplier bizSupplier)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertSupplier(bizSupplier);
                }
                )
            );
        }

        public string BizInsertCompany(BizCompany bizCompany)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertCompany(bizCompany);
                }
                )
            );
        }

        public string BizInsertUser(BizUser bizUser)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertUser(bizUser);
                }
                )
            );
        }

        public string BizInsertVehicle(BizVehicle bizVehicle)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertVehicle(bizVehicle);
                }
                )
            );
        }

        public string BizInsertAddress(BizAddress bizAddress)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertAddress(bizAddress);
                }
                )
            );
        }

        public string BizInsertCommitteeMember(BizCommitteeMember bizCommitteeMember)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertCommitteeMember(bizCommitteeMember);
                }
                )
            );
        }

        public string BizInsertEvent(BizEvent bizEvent)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertEvent(bizEvent);
                }
                )
            );
        }

        public string BizInsertTicket(BizTicket bizTicket)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertTicket(bizTicket);
                }
                )
            );
        }

        public string BizInsertVisit(BizVisit bizVisit)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertVisit(bizVisit);
                }
                )
            );
        }

        public string BizInsertAssistControl(BizAssistControl bizAssistControl)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertAssistControl(bizAssistControl);
                }
                )
            );
        }

        public string BizInsertPayment(BizPayment bizPayment)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertPayment(bizPayment);
                }
                )
            );
        }

        public string BizInsertInternalBox(BizInternalBox bizInternalBox)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertInternalBox(bizInternalBox);
                }
                )
            );
        }

        public string BizInsertInternalExpense(BizInternalExpense bizInternalExpense)
        {
            return BizCall(
                new Action(() =>
                {
                    insert.InsertInternalExpense(bizInternalExpense);
                }
                )
            );
        }
    }
}
