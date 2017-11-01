using System;
using RM.Core.Business.Entities.Views;
using RM.Core.Data.Biz;
using RM.Core.Data.Interface;

namespace RM.Core.Data.Implementation
{
    public class CrudFuntion : BizLogic, ICrudFuntion
    {

        #region INSERT

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
        #endregion

        #region GET
        #endregion

        #region DELETE
        #endregion

    }
}
