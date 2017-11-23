using RM.Core.Business.Entities.Views;
using RM.Core.Data.Entities;
using System.Collections.Generic;

namespace RM.Core.Data.Adapter
{
    /// <summary>
    /// Class BaseAdapter.
    /// </summary>
    public static class BaseAdapter
    {

        #region OBJECT-LIST

        /// <summary>
        /// Lists the data user to list biz user.
        /// </summary>
        /// <param name="DataUserList">The data user list.</param>
        /// <returns>List&lt;BizUser&gt;.</returns>
        public static List<BizUser> ListDataUserToListBizUser(this List<SYSGetUser_Result> DataUserList)
        {
            List<BizUser> bizUserList = new List<BizUser>();

            foreach (SYSGetUser_Result dataUser in DataUserList)
            {
                bizUserList.Add(dataUser.DataUserToBizUser());
            }

            return bizUserList; 
        }

        /// <summary>
        /// Lists the data address to list biz address.
        /// </summary>
        /// <param name="DataAddressList">The data address list.</param>
        /// <returns>List&lt;BizAddress&gt;.</returns>
        public static List<BizAddress> ListDataAddressToListBizAddress(this List<SYSGetAddress_Result> DataAddressList)
        {
            List<BizAddress> bizAddressList = new List<BizAddress>();

            foreach (SYSGetAddress_Result dataAddress in DataAddressList)
            {
                bizAddressList.Add(dataAddress.DataAddressToBizAddress());
            }

            return bizAddressList;
        }

        /// <summary>
        /// Lists the data assist control to list biz assist control.
        /// </summary>
        /// <param name="DataAssistControlList">The data assist control list.</param>
        /// <returns>List&lt;BizAssistControl&gt;.</returns>
        public static List<BizAssistControl> ListDataAssistControlToListBizAssistControl(this List<SYSGetAssistControl_Result> DataAssistControlList)
        {
            List<BizAssistControl> bizAssistControlList = new List<BizAssistControl>();

            foreach (SYSGetAssistControl_Result dataAssistControl in DataAssistControlList)
            {
                bizAssistControlList.Add(dataAssistControl.DataAssistControlToBizAssistControl());
            }

            return bizAssistControlList;
        }

        /// <summary>
        /// Lists the data committee member to list biz committee member.
        /// </summary>
        /// <param name="DataCommitteeMemberList">The data committee member list.</param>
        /// <returns>List&lt;BizCommitteeMember&gt;.</returns>
        public static List<BizCommitteeMember> ListDataCommitteeMemberToListBizCommitteeMember(this List<SYSGetCommitteeMember_Result> DataCommitteeMemberList)
        {
            List<BizCommitteeMember> bizCommitteeMemberList = new List<BizCommitteeMember>();

            foreach (SYSGetCommitteeMember_Result dataCommitteeMember in DataCommitteeMemberList)
            {
                bizCommitteeMemberList.Add(dataCommitteeMember.DataCommitteeMemberToBizCommitteeMember());
            }

            return bizCommitteeMemberList;
        }

        /// <summary>
        /// Lists the data company to list biz company.
        /// </summary>
        /// <param name="DataCompanyList">The data company list.</param>
        /// <returns>List&lt;BizCompany&gt;.</returns>
        public static List<BizCompany> ListDataCompanyToListBizCompany(this List<SYSGetCompany_Result> DataCompanyList)
        {
            List<BizCompany> bizCompanyList = new List<BizCompany>();

            foreach (SYSGetCompany_Result dataCompany in DataCompanyList)
            {
                bizCompanyList.Add(dataCompany.DataCompanyToBizCompany());
            }

            return bizCompanyList;
        }

        /// <summary>
        /// Lists the data event to list biz event.
        /// </summary>
        /// <param name="DataEventList">The data event list.</param>
        /// <returns>List&lt;BizEvent&gt;.</returns>
        public static List<BizEvent> ListDataEventToListBizEvent(this List<SYSGetEvent_Result> DataEventList)
        {
            List<BizEvent> bizEventList = new List<BizEvent>();

            foreach (SYSGetEvent_Result dataEvent in DataEventList)
            {
                bizEventList.Add(dataEvent.DataEventToBizEvent());
            }

            return bizEventList;
        }

        /// <summary>
        /// Lists the data event status to list biz event status.
        /// </summary>
        /// <param name="DataEventStatusList">The data event status list.</param>
        /// <returns>List&lt;BizEventStatus&gt;.</returns>
        public static List<BizEventStatus> ListDataEventStatusToListBizEventStatus(this List<SYSGetCatEventStatus_Result> DataEventStatusList)
        {
            List<BizEventStatus> bizEventStatusList = new List<BizEventStatus>();

            foreach (SYSGetCatEventStatus_Result dataEventStatus in DataEventStatusList)
            {
                bizEventStatusList.Add(dataEventStatus.DataEventStatusToBizEventStatus());
            }

            return bizEventStatusList;
        }

        /// <summary>
        /// Lists the data a eventuality to list biz eventuality.
        /// </summary>
        /// <param name="DataEventualityList">The data eventuality list.</param>
        /// <returns>List&lt;BizEventuality&gt;.</returns>
        public static List<BizEventuality> ListDataAEventualityToListBizEventuality(this List<SYSGetCatEventuality_Result> DataEventualityList)
        {
            List<BizEventuality> bizEventualityList = new List<BizEventuality>();

            foreach (SYSGetCatEventuality_Result dataEventuality in DataEventualityList)
            {
                bizEventualityList.Add(dataEventuality.DataEventualityToBizEventuality());
            }

            return bizEventualityList;
        }

        /// <summary>
        /// Lists the data internal box to list biz internal box.
        /// </summary>
        /// <param name="DataInternalBoxList">The data internal box list.</param>
        /// <returns>List&lt;BizInternalBox&gt;.</returns>
        public static List<BizInternalBox> ListDataInternalBoxToListBizInternalBox(this List<SYSGetInternalBox_Result> DataInternalBoxList)
        {
            List<BizInternalBox> bizInternalBoxList = new List<BizInternalBox>();

            foreach (SYSGetInternalBox_Result dataInternalBox in DataInternalBoxList)
            {
                bizInternalBoxList.Add(dataInternalBox.DataInternalBoxToBizInternalBox());
            }

            return bizInternalBoxList;
        }

        /// <summary>
        /// Lists the data internal expense to list biz internal expense.
        /// </summary>
        /// <param name="DataInternalExpenseList">The data internal expense list.</param>
        /// <returns>List&lt;BizInternalExpense&gt;.</returns>
        public static List<BizInternalExpense> ListDataInternalExpenseToListBizInternalExpense(this List<SYSGetInternalExpense_Result> DataInternalExpenseList)
        {
            List<BizInternalExpense> bizInternalExpenseList = new List<BizInternalExpense>();

            foreach (SYSGetInternalExpense_Result dataInternalExpense in DataInternalExpenseList)
            {
                bizInternalExpenseList.Add(dataInternalExpense.DataInternalExpenseToBizInternalExpense());
            }

            return bizInternalExpenseList;
        }

        /// <summary>
        /// Lists the data payment to list biz payment.
        /// </summary>
        /// <param name="DataPaymentList">The data payment list.</param>
        /// <returns>List&lt;BizPayment&gt;.</returns>
        public static List<BizPayment> ListDataPaymentToListBizPayment(this List<SYSGetPayment_Result> DataPaymentList)
        {
            List<BizPayment> bizPaymentList = new List<BizPayment>();

            foreach (SYSGetPayment_Result dataPayment in DataPaymentList)
            {
                bizPaymentList.Add(dataPayment.DataPaymentToBizPayment());
            }

            return bizPaymentList;
        }

        /// <summary>
        /// Lists the data payment status to list biz payment status.
        /// </summary>
        /// <param name="DataPaymentStatusList">The data payment status list.</param>
        /// <returns>List&lt;BizPaymentStatus&gt;.</returns>
        public static List<BizPaymentStatus> ListDataPaymentStatusToListBizPaymentStatus(this List<SYSGetCatPaymentStatus_Result> DataPaymentStatusList)
        {
            List<BizPaymentStatus> bizPaymentStatusList = new List<BizPaymentStatus>();

            foreach (SYSGetCatPaymentStatus_Result dataPaymentStatus in DataPaymentStatusList)
            {
                bizPaymentStatusList.Add(dataPaymentStatus.DataPaymentStatusToBizPaymentStatus());
            }

            return bizPaymentStatusList;
        }

        /// <summary>
        /// Lists the data recreational area to list biz recreational area.
        /// </summary>
        /// <param name="DataRecreationalAreaList">The data recreational area list.</param>
        /// <returns>List&lt;BizRecreationalArea&gt;.</returns>
        public static List<BizRecreationalArea> ListDataRecreationalAreaToListBizRecreationalArea(this List<SYSGetCatRecreationalArea_Result> DataRecreationalAreaList)
        {
            List<BizRecreationalArea> bizRecreationalAreaList = new List<BizRecreationalArea>();

            foreach (SYSGetCatRecreationalArea_Result dataRecreationalArea in DataRecreationalAreaList)
            {
                bizRecreationalAreaList.Add(dataRecreationalArea.DataRecreationalAreaToBizRecreationalArea());
            }

            return bizRecreationalAreaList;
        }

        /// <summary>
        /// Lists the data supplier to list biz supplier.
        /// </summary>
        /// <param name="DataSupplierList">The data supplier list.</param>
        /// <returns>List&lt;BizSupplier&gt;.</returns>
        public static List<BizSupplier> ListDataSupplierToListBizSupplier(this List<SYSGetCatSupplier_Result> DataSupplierList)
        {
            List<BizSupplier> bizSupplierList = new List<BizSupplier>();

            foreach (SYSGetCatSupplier_Result dataSupplier in DataSupplierList)
            {
                bizSupplierList.Add(dataSupplier.DataSupplierToBizSupplier());
            }

            return bizSupplierList;
        }

        /// <summary>
        /// Lists the data ticket to list biz ticket.
        /// </summary>
        /// <param name="DataTicketList">The data ticket list.</param>
        /// <returns>List&lt;BizTicket&gt;.</returns>
        public static List<BizTicket> ListDataTicketToListBizTicket(this List<SYSGetTicket_Result> DataTicketList)
        {
            List<BizTicket> bizTicketList = new List<BizTicket>();

            foreach (SYSGetTicket_Result dataTicket in DataTicketList)
            {
                bizTicketList.Add(dataTicket.DataTicketToBizTicket());
            }

            return bizTicketList;
        }

        /// <summary>
        /// Lists the data ticket status to list biz ticket status.
        /// </summary>
        /// <param name="DataTicketStatusList">The data ticket status list.</param>
        /// <returns>List&lt;BizTicketStatus&gt;.</returns>
        public static List<BizTicketStatus> ListDataTicketStatusToListBizTicketStatus(this List<SYSGetCatTicketStatus_Result> DataTicketStatusList)
        {
            List<BizTicketStatus> bizTicketStatusList = new List<BizTicketStatus>();

            foreach (SYSGetCatTicketStatus_Result dataTicketStatus in DataTicketStatusList)
            {
                bizTicketStatusList.Add(dataTicketStatus.DataTicketStatusToBizTicketStatus());
            }

            return bizTicketStatusList;
        }

        /// <summary>
        /// Lists the data type committee to list biz type committee.
        /// </summary>
        /// <param name="DataTypeCommitteeList">The data type committee list.</param>
        /// <returns>List&lt;BizTypeCommittee&gt;.</returns>
        public static List<BizTypeCommittee> ListDataTypeCommitteeToListBizTypeCommittee(this List<SYSGetCatTypeCommittee_Result> DataTypeCommitteeList)
        {
            List<BizTypeCommittee> bizTypeCommitteeList = new List<BizTypeCommittee>();

            foreach (SYSGetCatTypeCommittee_Result dataTypeCommittee in DataTypeCommitteeList)
            {
                bizTypeCommitteeList.Add(dataTypeCommittee.DataTypeCommitteeToBizTypeCommittee());
            }

            return bizTypeCommitteeList;
        }

        /// <summary>
        /// Lists the data type user to list biz type user.
        /// </summary>
        /// <param name="DataTypeUserList">The data type user list.</param>
        /// <returns>List&lt;BizTypeUser&gt;.</returns>
        public static List<BizTypeUser> ListDataTypeUserToListBizTypeUser(this List<SYSGetCatTypeUser_Result> DataTypeUserList)
        {
            List<BizTypeUser> bizTypeUserList = new List<BizTypeUser>();

            foreach (SYSGetCatTypeUser_Result dataTypeUser in DataTypeUserList)
            {
                bizTypeUserList.Add(dataTypeUser.DataTypeUserToBizTypeUser());
            }

            return bizTypeUserList;
        }

        /// <summary>
        /// Lists the data type visit to list biz type visit.
        /// </summary>
        /// <param name="DataTypeVisitList">The data type visit list.</param>
        /// <returns>List&lt;BizTypeVisit&gt;.</returns>
        public static List<BizTypeVisit> ListDataTypeVisitToListBizTypeVisit(this List<SYSGetCatTypeVisit_Result> DataTypeVisitList)
        {
            List<BizTypeVisit> bizTypeVisitList = new List<BizTypeVisit>();

            foreach (SYSGetCatTypeVisit_Result dataTypeVisit in DataTypeVisitList)
            {
                bizTypeVisitList.Add(dataTypeVisit.DataTypeVisitToBizTypeVisit());
            }

            return bizTypeVisitList;
        }

        /// <summary>
        /// Lists the data vehicle to list biz vehicle.
        /// </summary>
        /// <param name="DataVehicleList">The data vehicle list.</param>
        /// <returns>List&lt;BizVehicle&gt;.</returns>
        public static List<BizVehicle> ListDataVehicleToListBizVehicle(this List<SYSGetVehicle_Result> DataVehicleList)
        {
            List<BizVehicle> bizVehicleList = new List<BizVehicle>();

            foreach (SYSGetVehicle_Result dataVehicle in DataVehicleList)
            {
                bizVehicleList.Add(dataVehicle.DataVehicleToBizVehicle());
            }

            return bizVehicleList;
        }

        /// <summary>
        /// Lists the data visit to list biz visit.
        /// </summary>
        /// <param name="DataVisitList">The data visit list.</param>
        /// <returns>List&lt;BizVisit&gt;.</returns>
        public static List<BizVisit> ListDataVisitToListBizVisit(this List<SYSGetVisit_Result> DataVisitList)
        {
            List<BizVisit> bizVisitList = new List<BizVisit>();

            foreach (SYSGetVisit_Result dataVisit in DataVisitList)
            {
                bizVisitList.Add(dataVisit.DataVisitToBizVisit());
            }

            return bizVisitList;
        }

        #endregion


        #region OBJECT

        /// <summary>
        /// Datas the user log in to biz user.
        /// </summary>
        /// <param name="DataUser">The data user.</param>
        /// <returns>BizUser.</returns>
        public static BizUser DataUserLogInToBizUser(this SYSFuncLoginUser_Result DataUser)
        {
            BizUser bizUser = new BizUser
            {
                Id = DataUser.Id,
                CompanyId = 1,
                CompanyName = "",
                TypeId = DataUser.TypeId,
                UserType = "",
                UserName = DataUser.UserName,
                UserMiddleName = DataUser.UserMiddleName,
                UserLastName = DataUser.UserLastName,
                UserMotherName = DataUser.UserMotherName,
                Email = DataUser.Email,
                PassWord = DataUser.PassWord,
                PassWordSalt = DataUser.PassWordSalt,
                Active = DataUser.Active,
            };
            return bizUser;
        }

        /// <summary>
        /// Datas the user to biz user.
        /// </summary>
        /// <param name="DataUser">The data user.</param>
        /// <returns>BizUser.</returns>
        public static BizUser DataUserToBizUser(this SYSGetUser_Result DataUser)
        {
            BizUser bizUser = new BizUser
            {
                Id = DataUser.Id,
                CompanyId = 1,
                CompanyName = DataUser.CompanyName,
                TypeId = 0,
                UserType = DataUser.TypeUser,
                UserName = DataUser.UserName,
                UserMiddleName = DataUser.UserMiddleName,
                UserLastName = DataUser.UserLastName,
                UserMotherName = DataUser.UserMotherName,
                Email = DataUser.Email,
                PassWord = DataUser.PassWord,
                PassWordSalt = DataUser.PassWordSalt,
                Active = DataUser.Active,
            };
            return bizUser;
        }

        /// <summary>
        /// Datas the address to biz address.
        /// </summary>
        /// <param name="DataAddress">The data address.</param>
        /// <returns>BizAddress.</returns>
        public static BizAddress DataAddressToBizAddress(this SYSGetAddress_Result DataAddress)
        {
            BizAddress bizAdress = new BizAddress
            {
                Id = DataAddress.Id,
                UserId = DataAddress.UserId,
                StreetName = DataAddress.StreetName,
                Number = DataAddress.Number,
                PostalCode = DataAddress.PostalCode,
                Active = DataAddress.Active,
            };
            return bizAdress;
        }

        /// <summary>
        /// Datas the assist control to biz assist control.
        /// </summary>
        /// <param name="DataAssistControl">The data assist control.</param>
        /// <returns>BizAssistControl.</returns>
        public static BizAssistControl DataAssistControlToBizAssistControl(this SYSGetAssistControl_Result DataAssistControl)
        {
            BizAssistControl bizAssistControl = new BizAssistControl
            {
                Id = DataAssistControl.Id,
                UserId = DataAssistControl.UserId,
                CheckIn = DataAssistControl.CheckIn,
                CheckOut = DataAssistControl.CheckOut,
            };
            return bizAssistControl;
        }

        /// <summary>
        /// Datas the committee member to biz committee member.
        /// </summary>
        /// <param name="DataCommitteeMember">The data committee member.</param>
        /// <returns>BizCommitteeMember.</returns>
        public static BizCommitteeMember DataCommitteeMemberToBizCommitteeMember(this SYSGetCommitteeMember_Result DataCommitteeMember)
        {
            BizCommitteeMember bizCommitteeMember = new BizCommitteeMember
            {
                Id = DataCommitteeMember.Id,
                Nombre = DataCommitteeMember.Nombre,
                CommitteeType = DataCommitteeMember.TypeCommittee,
                Active = DataCommitteeMember.Active,
            };
            return bizCommitteeMember;
        }

        /// <summary>
        /// Datas the company to biz company.
        /// </summary>
        /// <param name="DataCompany">The data company.</param>
        /// <returns>BizCompany.</returns>
        public static BizCompany DataCompanyToBizCompany(this SYSGetCompany_Result DataCompany)
        {
            BizCompany bizCompany = new BizCompany
            {
                Id = DataCompany.Id,
                CompanyName = DataCompany.CompanyName,
                Active = DataCompany.Active,
            };
            return bizCompany;
        }

        /// <summary>
        /// Datas the event to biz event.
        /// </summary>
        /// <param name="DataEvent">The data event.</param>
        /// <returns>BizEvent.</returns>
        public static BizEvent DataEventToBizEvent(this SYSGetEvent_Result DataEvent)
        {
            BizEvent bizEvent = new BizEvent
            {
                Id = DataEvent.Id,
                UserId = 0,
                RecreationalAreaId = 0,
                StartDate = DataEvent.StartDate,
                EndDate = DataEvent.EndDate,
                StatusName = DataEvent.StatusName,
                Nombre = DataEvent.Nombre,
                AreaName = DataEvent.AreaName,
            };
            return bizEvent;
        }

        /// <summary>
        /// Datas the event status to biz event status.
        /// </summary>
        /// <param name="DataEventStatus">The data event status.</param>
        /// <returns>BizEventStatus.</returns>
        public static BizEventStatus DataEventStatusToBizEventStatus(this SYSGetCatEventStatus_Result DataEventStatus)
        {
            BizEventStatus bizEventStatus = new BizEventStatus
            {
                Id = DataEventStatus.Id,
                StatusName = DataEventStatus.StatusName,
                Active = DataEventStatus.Active,
            };
            return bizEventStatus;
        }

        /// <summary>
        /// Datas the eventuality to biz eventuality.
        /// </summary>
        /// <param name="DataEventuality">The data eventuality.</param>
        /// <returns>BizEventuality.</returns>
        public static BizEventuality DataEventualityToBizEventuality(this SYSGetCatEventuality_Result DataEventuality)
        {
            BizEventuality bizEventuality = new BizEventuality
            {
                Id = DataEventuality.Id,
                EventualityName = DataEventuality.EventualityName,
                Active = DataEventuality.Active,
            };
            return bizEventuality;
        }

        /// <summary>
        /// Datas the internal box to biz internal box.
        /// </summary>
        /// <param name="DataInternalBox">The data internal box.</param>
        /// <returns>BizInternalBox.</returns>
        public static BizInternalBox DataInternalBoxToBizInternalBox(this SYSGetInternalBox_Result DataInternalBox)
        {
            BizInternalBox bizInternalBox = new BizInternalBox
            {
                Amount = DataInternalBox.Amount,
                CreationDate = DataInternalBox.CreationDate,
            };
            return bizInternalBox;
        }

        /// <summary>
        /// Datas the internal expense to biz internal expense.
        /// </summary>
        /// <param name="DataInternalExpense">The data internal expense.</param>
        /// <returns>BizInternalExpense.</returns>
        public static BizInternalExpense DataInternalExpenseToBizInternalExpense(this SYSGetInternalExpense_Result DataInternalExpense)
        {
            BizInternalExpense bizInternalExpense = new BizInternalExpense
            {
                Id = DataInternalExpense.Id,
                UserId = DataInternalExpense.UserId,
                Amount = DataInternalExpense.Amount,
                CreationDate = DataInternalExpense.CreationDate,
            };
            return bizInternalExpense;
        }

        /// <summary>
        /// Datas the payment to biz payment.
        /// </summary>
        /// <param name="DataPayment">The data payment.</param>
        /// <returns>BizPayment.</returns>
        public static BizPayment DataPaymentToBizPayment(this SYSGetPayment_Result DataPayment)
        {
            BizPayment bizPayment = new BizPayment
            {
                Id = DataPayment.Id,
                UserId = 0,
                PaymentStatus = 0,
                Nombre = DataPayment.Nombre,
                Amount = DataPayment.Amount,
                StatusName = DataPayment.StatusName,
                PaymentDate = DataPayment.PaymentDate,
            };
            return bizPayment;
        }

        /// <summary>
        /// Datas the payment status to biz payment status.
        /// </summary>
        /// <param name="DataPaymentStatus">The data payment status.</param>
        /// <returns>BizPaymentStatus.</returns>
        public static BizPaymentStatus DataPaymentStatusToBizPaymentStatus(this SYSGetCatPaymentStatus_Result DataPaymentStatus)
        {
            BizPaymentStatus bizPaymentStatus = new BizPaymentStatus
            {
                Id = DataPaymentStatus.Id,
                StatusName = DataPaymentStatus.StatusName,
                Active = DataPaymentStatus.Active,
            };
            return bizPaymentStatus;
        }

        /// <summary>
        /// Datas the recreational area to biz recreational area.
        /// </summary>
        /// <param name="DataRecreationalArea">The data recreational area.</param>
        /// <returns>BizRecreationalArea.</returns>
        public static BizRecreationalArea DataRecreationalAreaToBizRecreationalArea(this SYSGetCatRecreationalArea_Result DataRecreationalArea)
        {
            BizRecreationalArea bizRecreationalArea = new BizRecreationalArea
            {
                Id = DataRecreationalArea.Id,
                AreaName = DataRecreationalArea.AreaName,
                Active = DataRecreationalArea.Active,
            };
            return bizRecreationalArea;
        }

        /// <summary>
        /// Datas the supplier to biz supplier.
        /// </summary>
        /// <param name="DataSupplier">The data supplier.</param>
        /// <returns>BizSupplier.</returns>
        public static BizSupplier DataSupplierToBizSupplier(this SYSGetCatSupplier_Result DataSupplier)
        {
            BizSupplier bizSupplier = new BizSupplier
            {
                Id = DataSupplier.Id,
                SupplierName = DataSupplier.SupplierName,
                ContactNumer = DataSupplier.ContactNumer,
                Active = DataSupplier.Active,
            };
            return bizSupplier;
        }

        /// <summary>
        /// Datas the ticket to biz ticket.
        /// </summary>
        /// <param name="DataTicket">The data ticket.</param>
        /// <returns>BizTicket.</returns>
        public static BizTicket DataTicketToBizTicket(this SYSGetTicket_Result DataTicket)
        {
            BizTicket bizTicket = new BizTicket
            {
                Id = DataTicket.Id,
                UserId = 0,
                EventualityId = 0,
                StatusId = 0,
                Nombre = DataTicket.Nombre,
                EventualityName = DataTicket.EventualityName,
                StatusName = DataTicket.StatusName,
                CreationDate = DataTicket.CreationDate,
                ModificationDate = DataTicket.ModificationDate,
            };
            return bizTicket;
        }

        /// <summary>
        /// Datas the ticket status to biz ticket status.
        /// </summary>
        /// <param name="DataTicketStatus">The data ticket status.</param>
        /// <returns>BizTicketStatus.</returns>
        public static BizTicketStatus DataTicketStatusToBizTicketStatus(this SYSGetCatTicketStatus_Result DataTicketStatus)
        {
            BizTicketStatus bizTicketStatus = new BizTicketStatus
            {
                Id = DataTicketStatus.Id,
                StatusName = DataTicketStatus.StatusName,
                Active = DataTicketStatus.Active,
            };
            return bizTicketStatus;
        }

        /// <summary>
        /// Datas the type committee to biz type committee.
        /// </summary>
        /// <param name="DataTypeCommittee">The data type committee.</param>
        /// <returns>BizTypeCommittee.</returns>
        public static BizTypeCommittee DataTypeCommitteeToBizTypeCommittee(this SYSGetCatTypeCommittee_Result DataTypeCommittee)
        {
            BizTypeCommittee bizTypeCommittee = new BizTypeCommittee
            {
                Id = DataTypeCommittee.Id,
                TypeCommittee = DataTypeCommittee.TypeCommittee,
                Active = DataTypeCommittee.Active,
            };
            return bizTypeCommittee;
        }

        /// <summary>
        /// Datas the type user to biz type user.
        /// </summary>
        /// <param name="DataTypeUser">The data type user.</param>
        /// <returns>BizTypeUser.</returns>
        public static BizTypeUser DataTypeUserToBizTypeUser(this SYSGetCatTypeUser_Result DataTypeUser)
        {
            BizTypeUser bizTypeUser = new BizTypeUser
            {
                Id = DataTypeUser.Id,
                TypeUser = DataTypeUser.TypeUser,
                Active = DataTypeUser.Active,
            };
            return bizTypeUser;
        }

        /// <summary>
        /// Datas the type visit to biz type visit.
        /// </summary>
        /// <param name="DatTypeVisit">The dat type visit.</param>
        /// <returns>BizTypeVisit.</returns>
        public static BizTypeVisit DataTypeVisitToBizTypeVisit(this SYSGetCatTypeVisit_Result DatTypeVisit)
        {
            BizTypeVisit bizTypeVisit = new BizTypeVisit
            {
                Id = DatTypeVisit.Id,
                TypeVisit = DatTypeVisit.TypeVisit,
                Active = DatTypeVisit.Active,
            };
            return bizTypeVisit;
        }

        /// <summary>
        /// Datas the vehicle to biz vehicle.
        /// </summary>
        /// <param name="DatVehicle">The dat vehicle.</param>
        /// <returns>BizVehicle.</returns>
        public static BizVehicle DataVehicleToBizVehicle(this SYSGetVehicle_Result DatVehicle)
        {
            BizVehicle bizVehicle = new BizVehicle
            {
                Id = DatVehicle.Id,
                UserId = 0,
                Nombre = DatVehicle.Nombre,
                Plates = DatVehicle.Plates,
                Model = DatVehicle.Model,
                Active = DatVehicle.Active,
            };
            return bizVehicle;
        }

        /// <summary>
        /// Datas the visit to biz visit.
        /// </summary>
        /// <param name="DatVisit">The dat visit.</param>
        /// <returns>BizVisit.</returns>
        public static BizVisit DataVisitToBizVisit(this SYSGetVisit_Result DatVisit)
        {
            BizVisit bizVisit = new BizVisit
            {
                Id = DatVisit.Id,
                UserId = 0,
                VisitId = 0,
                CheckIn = DatVisit.CheckIn,
                CheckOut = DatVisit.CheckOut,
                VisitName = DatVisit.VisitName,
                Carnet = DatVisit.Carnet,
                Plates = DatVisit.Plates,
                Nombre = DatVisit.Nombre,
                TypeVisit = DatVisit.TypeVisit,
            };
            return bizVisit;
        }

        #endregion
    }
}
