using RM.Core.Business.Entities.Views;
using RM.Core.Data.Entities;
using System.Collections.Generic;

namespace RM.Core.Data.Adapter
{
    public static class BaseAdapter
    {

        #region OBJECT-LIST

        public static List<BizUser> ListDataUserToListBizUser(this List<SYSGetUser_Result> DataUserList)
        {
            List<BizUser> bizUserList = new List<BizUser>();

            foreach (SYSGetUser_Result dataUser in DataUserList)
            {
                bizUserList.Add(dataUser.DataUserToBizUser());
            }

            return bizUserList; 
        }

        public static List<BizAddress> ListDataAddressToListBizAddress(this List<SYSGetAddress_Result> DataAddressList)
        {
            List<BizAddress> bizAddressList = new List<BizAddress>();

            foreach (SYSGetAddress_Result dataAddress in DataAddressList)
            {
                bizAddressList.Add(dataAddress.DataAddressToBizAddress());
            }

            return bizAddressList;
        }

        public static List<BizAssistControl> ListDataAssistControlToListBizAssistControl(this List<SYSGetAssistControl_Result> DataAssistControlList)
        {
            List<BizAssistControl> bizAssistControlList = new List<BizAssistControl>();

            foreach (SYSGetAssistControl_Result dataAssistControl in DataAssistControlList)
            {
                bizAssistControlList.Add(dataAssistControl.DataAssistControlToBizAssistControl());
            }

            return bizAssistControlList;
        }

        public static List<BizCommitteeMember> ListDataCommitteeMemberToListBizCommitteeMember(this List<SYSGetCommitteeMember_Result> DataCommitteeMemberList)
        {
            List<BizCommitteeMember> bizCommitteeMemberList = new List<BizCommitteeMember>();

            foreach (SYSGetCommitteeMember_Result dataCommitteeMember in DataCommitteeMemberList)
            {
                bizCommitteeMemberList.Add(dataCommitteeMember.DataCommitteeMemberToBizCommitteeMember());
            }

            return bizCommitteeMemberList;
        }

        public static List<BizCompany> ListDataCompanyToListBizCompany(this List<SYSGetCompany_Result> DataCompanyList)
        {
            List<BizCompany> bizCompanyList = new List<BizCompany>();

            foreach (SYSGetCompany_Result dataCompany in DataCompanyList)
            {
                bizCompanyList.Add(dataCompany.DataCompanyToBizCompany());
            }

            return bizCompanyList;
        }

        public static List<BizEvent> ListDataEventToListBizEvent(this List<SYSGetEvent_Result> DataEventList)
        {
            List<BizEvent> bizEventList = new List<BizEvent>();

            foreach (SYSGetEvent_Result dataEvent in DataEventList)
            {
                bizEventList.Add(dataEvent.DataEventToBizEvent());
            }

            return bizEventList;
        }

        public static List<BizEventStatus> ListDataEventStatusToListBizEventStatus(this List<SYSGetCatEventStatus_Result> DataEventStatusList)
        {
            List<BizEventStatus> bizEventStatusList = new List<BizEventStatus>();

            foreach (SYSGetCatEventStatus_Result dataEventStatus in DataEventStatusList)
            {
                bizEventStatusList.Add(dataEventStatus.DataEventStatusToBizEventStatus());
            }

            return bizEventStatusList;
        }

        public static List<BizEventuality> ListDataAEventualityToListBizEventuality(this List<SYSGetCatEventuality_Result> DataEventualityList)
        {
            List<BizEventuality> bizEventualityList = new List<BizEventuality>();

            foreach (SYSGetCatEventuality_Result dataEventuality in DataEventualityList)
            {
                bizEventualityList.Add(dataEventuality.DataEventualityToBizEventuality());
            }

            return bizEventualityList;
        }

        public static List<BizInternalBox> ListDataInternalBoxToListBizInternalBox(this List<SYSGetInternalBox_Result> DataInternalBoxList)
        {
            List<BizInternalBox> bizInternalBoxList = new List<BizInternalBox>();

            foreach (SYSGetInternalBox_Result dataInternalBox in DataInternalBoxList)
            {
                bizInternalBoxList.Add(dataInternalBox.DataInternalBoxToBizInternalBox());
            }

            return bizInternalBoxList;
        }

        public static List<BizInternalExpense> ListDataInternalExpenseToListBizInternalExpense(this List<SYSGetInternalExpense_Result> DataInternalExpenseList)
        {
            List<BizInternalExpense> bizInternalExpenseList = new List<BizInternalExpense>();

            foreach (SYSGetInternalExpense_Result dataInternalExpense in DataInternalExpenseList)
            {
                bizInternalExpenseList.Add(dataInternalExpense.DataInternalExpenseToBizInternalExpense());
            }

            return bizInternalExpenseList;
        }

        public static List<BizPayment> ListDataPaymentToListBizPayment(this List<SYSGetPayment_Result> DataPaymentList)
        {
            List<BizPayment> bizPaymentList = new List<BizPayment>();

            foreach (SYSGetPayment_Result dataPayment in DataPaymentList)
            {
                bizPaymentList.Add(dataPayment.DataPaymentToBizPayment());
            }

            return bizPaymentList;
        }

        public static List<BizPaymentStatus> ListDataPaymentStatusToListBizPaymentStatus(this List<SYSGetCatPaymentStatus_Result> DataPaymentStatusList)
        {
            List<BizPaymentStatus> bizPaymentStatusList = new List<BizPaymentStatus>();

            foreach (SYSGetCatPaymentStatus_Result dataPaymentStatus in DataPaymentStatusList)
            {
                bizPaymentStatusList.Add(dataPaymentStatus.DataPaymentStatusToBizPaymentStatus());
            }

            return bizPaymentStatusList;
        }

        public static List<BizRecreationalArea> ListDataRecreationalAreaToListBizRecreationalArea(this List<SYSGetCatRecreationalArea_Result> DataRecreationalAreaList)
        {
            List<BizRecreationalArea> bizRecreationalAreaList = new List<BizRecreationalArea>();

            foreach (SYSGetCatRecreationalArea_Result dataRecreationalArea in DataRecreationalAreaList)
            {
                bizRecreationalAreaList.Add(dataRecreationalArea.DataRecreationalAreaToBizRecreationalArea());
            }

            return bizRecreationalAreaList;
        }

        public static List<BizSupplier> ListDataSupplierToListBizSupplier(this List<SYSGetCatSupplier_Result> DataSupplierList)
        {
            List<BizSupplier> bizSupplierList = new List<BizSupplier>();

            foreach (SYSGetCatSupplier_Result dataSupplier in DataSupplierList)
            {
                bizSupplierList.Add(dataSupplier.DataSupplierToBizSupplier());
            }

            return bizSupplierList;
        }

        public static List<BizTicket> ListDataTicketToListBizTicket(this List<SYSGetTicket_Result> DataTicketList)
        {
            List<BizTicket> bizTicketList = new List<BizTicket>();

            foreach (SYSGetTicket_Result dataTicket in DataTicketList)
            {
                bizTicketList.Add(dataTicket.DataTicketToBizTicket());
            }

            return bizTicketList;
        }

        public static List<BizTicketStatus> ListDataTicketStatusToListBizTicketStatus(this List<SYSGetCatTicketStatus_Result> DataTicketStatusList)
        {
            List<BizTicketStatus> bizTicketStatusList = new List<BizTicketStatus>();

            foreach (SYSGetCatTicketStatus_Result dataTicketStatus in DataTicketStatusList)
            {
                bizTicketStatusList.Add(dataTicketStatus.DataTicketStatusToBizTicketStatus());
            }

            return bizTicketStatusList;
        }

        public static List<BizTypeCommittee> ListDataTypeCommitteeToListBizTypeCommittee(this List<SYSGetCatTypeCommittee_Result> DataTypeCommitteeList)
        {
            List<BizTypeCommittee> bizTypeCommitteeList = new List<BizTypeCommittee>();

            foreach (SYSGetCatTypeCommittee_Result dataTypeCommittee in DataTypeCommitteeList)
            {
                bizTypeCommitteeList.Add(dataTypeCommittee.DataTypeCommitteeToBizTypeCommittee());
            }

            return bizTypeCommitteeList;
        }

        public static List<BizTypeUser> ListDataTypeUserToListBizTypeUser(this List<SYSGetCatTypeUser_Result> DataTypeUserList)
        {
            List<BizTypeUser> bizTypeUserList = new List<BizTypeUser>();

            foreach (SYSGetCatTypeUser_Result dataTypeUser in DataTypeUserList)
            {
                bizTypeUserList.Add(dataTypeUser.DataTypeUserToBizTypeUser());
            }

            return bizTypeUserList;
        }

        public static List<BizTypeVisit> ListDataTypeVisitToListBizTypeVisit(this List<SYSGetCatTypeVisit_Result> DataTypeVisitList)
        {
            List<BizTypeVisit> bizTypeVisitList = new List<BizTypeVisit>();

            foreach (SYSGetCatTypeVisit_Result dataTypeVisit in DataTypeVisitList)
            {
                bizTypeVisitList.Add(dataTypeVisit.DataTypeVisitToBizTypeVisit());
            }

            return bizTypeVisitList;
        }

        public static List<BizVehicle> ListDataVehicleToListBizVehicle(this List<SYSGetVehicle_Result> DataVehicleList)
        {
            List<BizVehicle> bizVehicleList = new List<BizVehicle>();

            foreach (SYSGetVehicle_Result dataVehicle in DataVehicleList)
            {
                bizVehicleList.Add(dataVehicle.DataVehicleToBizVehicle());
            }

            return bizVehicleList;
        }

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

        public static BizInternalBox DataInternalBoxToBizInternalBox(this SYSGetInternalBox_Result DataInternalBox)
        {
            BizInternalBox bizInternalBox = new BizInternalBox
            {
                Amount = DataInternalBox.Amount,
                CreationDate = DataInternalBox.CreationDate,
            };
            return bizInternalBox;
        }

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
