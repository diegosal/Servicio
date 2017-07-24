using System;
using RM.Core.Business.Entities.Views;
using RM.Core.Data.Biz;
using RM.Core.Data.Interface;

namespace RM.Core.Data.Implementation
{
    public class Insert : BizLogic, IInsert
    {
        public string InsertAddress(BizAddress bizAddress)
        {
            string Result = "";
            int  result = 0;
            Result = BizCall(
                new Action(() =>
                    {
                        result = dbContext.SYSInsertAddress (
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

        public string InsertAssistControl(BizAssistControl bizAssistControl)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertAssistControl(
                            bizAssistControl.UserId
                        );
                }
                )
            );
            return Result;
        }

        public string InsertCommitteeMember(BizCommitteeMember bizCommitteeMember)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertCommitteeMember(
                            bizCommitteeMember.UserId,
                            bizCommitteeMember.CommitteeTypeId,
                            bizCommitteeMember.Active
                        );
                }
                )
            );
            return Result;
        }

        public string InsertCompany(BizCompany bizCompany)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertCompany(
                            bizCompany.CompanyName,
                            bizCompany.Active
                        );
                }
                )
            );
            return Result;
        }

        public string InsertEvent(BizEvent bizEvent)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertEvent(
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

        public string InsertEventuality(BizEventuality bizEventuality)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertCatEventuality(
                            bizEventuality.EventualityName,
                            bizEventuality.Active
                        );
                }
                )
            );
            return Result;
        }

        public string InsertInternalBox(BizInternalBox bizInternalBox)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertInternalBox(
                            bizInternalBox.Amount
                        );
                }
                )
            );
            return Result;
        }

        public string InsertInternalExpense(BizInternalExpense bizInternalExpense)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertInternalExpense(
                            bizInternalExpense.UserId,
                            bizInternalExpense.Amount
                        );
                }
                )
            );
            return Result;
        }

        public string InsertPayment(BizPayment bizPayment)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertPayment(
                            bizPayment.UserId,
                            bizPayment.Amount,
                            bizPayment.PaymentStatus
                        );
                }
                )
            );
            return Result;
        }

        public string InsertRecreationalArea(BizRecreationalArea bizRecreationalArea)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertCatRecreationalArea(
                            bizRecreationalArea.AreaName,
                            bizRecreationalArea.Active
                        );
                }
                )
            );
            return Result;
        }

        public string InsertTicketStatus(BizTicketStatus bizTicketStatus)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertCatTicketStatus(
                            bizTicketStatus.StatusName,
                            bizTicketStatus.Active
                        );
                }
                )
            );
            return Result;
        }

        public string InsertSupplier(BizSupplier bizSupplier)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertCatSupplier(
                            bizSupplier.SupplierName,
                            bizSupplier.ContactNumer,
                            bizSupplier.Active
                        );
                }
                )
            );
            return Result;
        }

        public string InsertTicket(BizTicket bizTicket)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertTicket(
                            bizTicket.UserId,
                            bizTicket.EventualityId,
                            bizTicket.StatusId
                        );
                }
                )
            );
            return Result;
        }

        public string InsertTypeCommittee(BizTypeCommittee bizTypeCommittee)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertCatTypeCommittee(
                            bizTypeCommittee.TypeCommittee,
                            bizTypeCommittee.Active
                        );
                }
                )
            );
            return Result;
        }

        public string InsertTypeUser(BizTypeUser bizTypeUser)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertCatTypeUser(
                            bizTypeUser.TypeUser,
                            bizTypeUser.Active
                        );
                }
                )
            );
            return Result;
        }

        public string InsertTypeVisit(BizTypeVisit bizTypeVisit)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertCatTypeVisit(
                           bizTypeVisit.TypeVisit,
                           bizTypeVisit.Active
                        );
                }
                )
            );
            return Result;
        }

        public string InsertUser(BizUser bizUser)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertUser(
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

        public string InsertVehicle(BizVehicle bizVehicle)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertVehiclee(
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

        public string InsertVisit(BizVisit bizVisit)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertVisit(
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

        public string InsertPaymentStatus(BizPaymentStatus bizPaymentStatus)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertCatPaymentStatus(
                            bizPaymentStatus.StatusName,
                            bizPaymentStatus.Active
                        );
                }
                )
            );
            return Result;
        }

        public string InsertEventStatus(BizEventStatus bizEventStatus)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSInsertCatEventStatus(
                            bizEventStatus.StatusName,
                            bizEventStatus.Active
                        );
                }
                )
            );
            return Result;
        }
    }
}
