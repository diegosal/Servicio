﻿using System;
using System.Collections.Generic;
using RM.Core.Business.Entities.Views;
using RM.Core.Data.Biz;
using RM.Core.Data.Interface;
using RM.Core.Data.Adapter;

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

        public string UpdateUserPassWord(BizUser bizUser)
        {
            string Result = "";
            int result = 0;
            Result = BizCall(
                new Action(() =>
                {
                    result = dbContext.SYSUpdUserPassWord(
                                      bizUser.Id,
                                      bizUser.PassWord,
                                      bizUser.PassWordSalt
                        );
                }
                )
            );
            return Result;
        }

        #endregion

        #region GET

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

        public string DeleteRecreationalArea(BizRecreationalArea bizRecreationalArea)
        {
            throw new NotImplementedException();
        }

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

        public string DeleteSupplier(BizSupplier bizSupplier)
        {
            throw new NotImplementedException();
        }

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

        public string DeleteVehicle(BizVehicle bizVehicle)
        {
            throw new NotImplementedException();
        }

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
