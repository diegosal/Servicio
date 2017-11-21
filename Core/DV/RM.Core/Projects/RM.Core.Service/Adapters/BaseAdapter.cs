using RM.Core.Business.Entities.Views;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;

namespace RM.Core.Service.Adapters
{
    public static class BaseAdapter
    {
        #region OBJECT-LIST

        public static List<WebUser> ListBizUserToListWebUser(this List<BizUser> DataUserList)
        {
            List<WebUser> WebUserList = new List<WebUser>();

            foreach (BizUser dataUser in DataUserList)
            {
                WebUserList.Add(dataUser.BizUserToWebUser());
            }

            return WebUserList;
        }

        public static List<WebAddress> ListBizAddressToListWebAddress(this List<BizAddress> DataAddressList)
        {
            List<WebAddress> WebAddressList = new List<WebAddress>();

            foreach (BizAddress dataAddress in DataAddressList)
            {
                WebAddressList.Add(dataAddress.BizAddressToWebAddress());
            }

            return WebAddressList;
        }

        public static List<WebAssistControl> ListBizAssistControlToListWebAssistControl(this List<BizAssistControl> DataAssistControlList)
        {
            List<WebAssistControl> WebAssistControlList = new List<WebAssistControl>();

            foreach (BizAssistControl dataAssistControl in DataAssistControlList)
            {
                WebAssistControlList.Add(dataAssistControl.BizAssistControlToWebAssistControl());
            }

            return WebAssistControlList;
        }

        public static List<WebCommitteeMember> ListBizCommitteeMemberToListWebCommitteeMember(this List<BizCommitteeMember> DataCommitteeMemberList)
        {
            List<WebCommitteeMember> WebCommitteeMemberList = new List<WebCommitteeMember>();

            foreach (BizCommitteeMember dataCommitteeMember in DataCommitteeMemberList)
            {
                WebCommitteeMemberList.Add(dataCommitteeMember.BizCommitteeMemberToWebCommitteeMember());
            }

            return WebCommitteeMemberList;
        }

        public static List<WebCompany> ListBizCompanyToListWebCompany(this List<BizCompany> DataCompanyList)
        {
            List<WebCompany> WebCompanyList = new List<WebCompany>();

            foreach (BizCompany dataCompany in DataCompanyList)
            {
                WebCompanyList.Add(dataCompany.BizCompanyToWebCompany());
            }

            return WebCompanyList;
        }

        public static List<WebEvent> ListBizEventToListWebEvent(this List<BizEvent> DataEventList)
        {
            List<WebEvent> WebEventList = new List<WebEvent>();

            foreach (BizEvent dataEvent in DataEventList)
            {
                WebEventList.Add(dataEvent.BizEventToWebEvent());
            }

            return WebEventList;
        }

        public static List<WebEventStatus> ListBizEventStatusToListWebEventStatus(this List<BizEventStatus> DataEventStatusList)
        {
            List<WebEventStatus> WebEventStatusList = new List<WebEventStatus>();

            foreach (BizEventStatus dataEventStatus in DataEventStatusList)
            {
                WebEventStatusList.Add(dataEventStatus.BizEventStatusToWebEventStatus());
            }

            return WebEventStatusList;
        }

        public static List<WebEventuality> ListBizAEventualityToListWebEventuality(this List<BizEventuality> DataEventualityList)
        {
            List<WebEventuality> WebEventualityList = new List<WebEventuality>();

            foreach (BizEventuality dataEventuality in DataEventualityList)
            {
                WebEventualityList.Add(dataEventuality.BizEventualityToWebEventuality());
            }

            return WebEventualityList;
        }

        public static List<WebInternalBox> ListBizInternalBoxToListWebInternalBox(this List<BizInternalBox> DataInternalBoxList)
        {
            List<WebInternalBox> WebInternalBoxList = new List<WebInternalBox>();

            foreach (BizInternalBox dataInternalBox in DataInternalBoxList)
            {
                WebInternalBoxList.Add(dataInternalBox.BizInternalBoxToWebInternalBox());
            }

            return WebInternalBoxList;
        }

        public static List<WebInternalExpense> ListBizInternalExpenseToListWebInternalExpense(this List<BizInternalExpense> DataInternalExpenseList)
        {
            List<WebInternalExpense> WebInternalExpenseList = new List<WebInternalExpense>();

            foreach (BizInternalExpense dataInternalExpense in DataInternalExpenseList)
            {
                WebInternalExpenseList.Add(dataInternalExpense.BizInternalExpenseToWebInternalExpense());
            }

            return WebInternalExpenseList;
        }

        public static List<WebPayment> ListBizPaymentToListWebPayment(this List<BizPayment> DataPaymentList)
        {
            List<WebPayment> WebPaymentList = new List<WebPayment>();

            foreach (BizPayment dataPayment in DataPaymentList)
            {
                WebPaymentList.Add(dataPayment.BizPaymentToWebPayment());
            }

            return WebPaymentList;
        }

        public static List<WebPaymentStatus> ListBizPaymentStatusToListWebPaymentStatus(this List<BizPaymentStatus> DataPaymentStatusList)
        {
            List<WebPaymentStatus> WebPaymentStatusList = new List<WebPaymentStatus>();

            foreach (BizPaymentStatus dataPaymentStatus in DataPaymentStatusList)
            {
                WebPaymentStatusList.Add(dataPaymentStatus.BizPaymentStatusToWebPaymentStatus());
            }

            return WebPaymentStatusList;
        }

        public static List<WebRecreationalArea> ListBizRecreationalAreaToListWebRecreationalArea(this List<BizRecreationalArea> DataRecreationalAreaList)
        {
            List<WebRecreationalArea> WebRecreationalAreaList = new List<WebRecreationalArea>();

            foreach (BizRecreationalArea dataRecreationalArea in DataRecreationalAreaList)
            {
                WebRecreationalAreaList.Add(dataRecreationalArea.BizRecreationalAreaToWebRecreationalArea());
            }

            return WebRecreationalAreaList;
        }

        public static List<WebSupplier> ListBizSupplierToListWebSupplier(this List<BizSupplier> DataSupplierList)
        {
            List<WebSupplier> WebSupplierList = new List<WebSupplier>();

            foreach (BizSupplier dataSupplier in DataSupplierList)
            {
                WebSupplierList.Add(dataSupplier.BizSupplierToWebSupplier());
            }

            return WebSupplierList;
        }

        public static List<WebTicket> ListBizTicketToListWebTicket(this List<BizTicket> DataTicketList)
        {
            List<WebTicket> WebTicketList = new List<WebTicket>();

            foreach (BizTicket dataTicket in DataTicketList)
            {
                WebTicketList.Add(dataTicket.BizTicketToWebTicket());
            }

            return WebTicketList;
        }

        public static List<WebTicketStatus> ListBizTicketStatusToListWebTicketStatus(this List<BizTicketStatus> DataTicketStatusList)
        {
            List<WebTicketStatus> WebTicketStatusList = new List<WebTicketStatus>();

            foreach (BizTicketStatus dataTicketStatus in DataTicketStatusList)
            {
                WebTicketStatusList.Add(dataTicketStatus.BizTicketStatusToWebTicketStatus());
            }

            return WebTicketStatusList;
        }

        public static List<WebTypeCommittee> ListBizTypeCommitteeToListWebTypeCommittee(this List<BizTypeCommittee> DataTypeCommitteeList)
        {
            List<WebTypeCommittee> WebTypeCommitteeList = new List<WebTypeCommittee>();

            foreach (BizTypeCommittee dataTypeCommittee in DataTypeCommitteeList)
            {
                WebTypeCommitteeList.Add(dataTypeCommittee.BizTypeCommitteeToWebTypeCommittee());
            }

            return WebTypeCommitteeList;
        }

        public static List<WebTypeUser> ListBizTypeUserToListWebTypeUser(this List<BizTypeUser> DataTypeUserList)
        {
            List<WebTypeUser> WebTypeUserList = new List<WebTypeUser>();

            foreach (BizTypeUser dataTypeUser in DataTypeUserList)
            {
                WebTypeUserList.Add(dataTypeUser.BizTypeUserToWebTypeUser());
            }

            return WebTypeUserList;
        }

        public static List<WebTypeVisit> ListBizTypeVisitToListWebTypeVisit(this List<BizTypeVisit> DataTypeVisitList)
        {
            List<WebTypeVisit> WebTypeVisitList = new List<WebTypeVisit>();

            foreach (BizTypeVisit dataTypeVisit in DataTypeVisitList)
            {
                WebTypeVisitList.Add(dataTypeVisit.BizTypeVisitToWebTypeVisit());
            }

            return WebTypeVisitList;
        }

        public static List<WebVehicle> ListBizVehicleToListWebVehicle(this List<BizVehicle> DataVehicleList)
        {
            List<WebVehicle> WebVehicleList = new List<WebVehicle>();

            foreach (BizVehicle dataVehicle in DataVehicleList)
            {
                WebVehicleList.Add(dataVehicle.BizVehicleToWebVehicle());
            }

            return WebVehicleList;
        }

        public static List<WebVisit> ListBizVisitToListWebVisit(this List<BizVisit> DataVisitList)
        {
            List<WebVisit> WebVisitList = new List<WebVisit>();

            foreach (BizVisit dataVisit in DataVisitList)
            {
                WebVisitList.Add(dataVisit.BizVisitToWebVisit());
            }

            return WebVisitList;
        }

        #endregion

        #region OBJECT

        public static BizUser WebUserToBizUser(this WebUser DataUser)
        {
            BizUser bizUser = new BizUser
            {
                Id = DataUser.Id,
                CompanyId = DataUser.CompanyId,
                CompanyName = DataUser.CompanyName,
                TypeId = DataUser.TypeId,
                UserType = DataUser.UserType,
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

        public static WebUser BizUserToWebUser(this BizUser DataUser)
        {
            WebUser webUser = new WebUser
            {
                Id = DataUser.Id,
                CompanyId = DataUser.CompanyId,
                CompanyName = DataUser.CompanyName,
                TypeId = DataUser.TypeId,
                UserType = DataUser.UserType,
                UserName = DataUser.UserName,
                UserMiddleName = DataUser.UserMiddleName,
                UserLastName = DataUser.UserLastName,
                UserMotherName = DataUser.UserMotherName,
                Email = DataUser.Email,
                PassWord = DataUser.PassWord,
                PassWordSalt = DataUser.PassWordSalt,
                Active = DataUser.Active,
            };
            return webUser;
        }

        public static BizAddress WebAddressToBizAddress(this WebAddress DataAddress)
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

        public static WebAddress BizAddressToWebAddress(this BizAddress DataAddress)
        {
            WebAddress webAdress = new WebAddress
            {
                Id = DataAddress.Id,
                UserId = DataAddress.UserId,
                StreetName = DataAddress.StreetName,
                Number = DataAddress.Number,
                PostalCode = DataAddress.PostalCode,
                Active = DataAddress.Active,
            };
            return webAdress;
        }

        public static BizAssistControl WebAssistControlToBizAssistControl(this WebAssistControl DataAssistControl)
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

        public static WebAssistControl BizAssistControlToWebAssistControl(this BizAssistControl DataAssistControl)
        {
            WebAssistControl webAssistControl = new WebAssistControl
            {
                Id = DataAssistControl.Id,
                UserId = DataAssistControl.UserId,
                CheckIn = DataAssistControl.CheckIn,
                CheckOut = DataAssistControl.CheckOut,
            };
            return webAssistControl;
        }

        public static BizCommitteeMember WebCommitteeMemberToBizCommitteeMember(this WebCommitteeMember DataCommitteeMember)
        {
            BizCommitteeMember bizCommitteeMember = new BizCommitteeMember
            {
                Id = DataCommitteeMember.Id,
                CommitteeTypeId = DataCommitteeMember.CommitteeTypeId,
                UserId = DataCommitteeMember.UserId,
                Nombre = DataCommitteeMember.Nombre,
                CommitteeType = DataCommitteeMember.CommitteeType,
                Active = DataCommitteeMember.Active,
            };
            return bizCommitteeMember;
        }

        public static WebCommitteeMember BizCommitteeMemberToWebCommitteeMember(this BizCommitteeMember DataCommitteeMember)
        {
            WebCommitteeMember webCommitteeMember = new WebCommitteeMember
            {
                Id = DataCommitteeMember.Id,
                CommitteeTypeId = DataCommitteeMember.CommitteeTypeId,
                UserId = DataCommitteeMember.UserId,
                Nombre = DataCommitteeMember.Nombre,
                CommitteeType = DataCommitteeMember.CommitteeType,
                Active = DataCommitteeMember.Active,
            };
            return webCommitteeMember;
        }

        public static BizCompany WebCompanyToBizCompany(this WebCompany DataCompany)
        {
            BizCompany bizCompany = new BizCompany
            {
                Id = DataCompany.Id,
                CompanyName = DataCompany.CompanyName,
                Active = DataCompany.Active,
            };
            return bizCompany;
        }

        public static WebCompany BizCompanyToWebCompany(this BizCompany DataCompany)
        {
            WebCompany webCompany = new WebCompany
            {
                Id = DataCompany.Id,
                CompanyName = DataCompany.CompanyName,
                Active = DataCompany.Active,
            };
            return webCompany;
        }

        public static BizEvent BizEventToWebEvent(this WebEvent DataEvent)
        {
            BizEvent bizEvent = new BizEvent
            {
                Id = DataEvent.Id,
                UserId = DataEvent.UserId,
                RecreationalAreaId = DataEvent.RecreationalAreaId,
                Status = DataEvent.Status,
                StartDate = DataEvent.StartDate,
                EndDate = DataEvent.EndDate,
                StatusName = DataEvent.StatusName,
                Nombre = DataEvent.Nombre,
                AreaName = DataEvent.AreaName,
            };
            return bizEvent;
        }

        public static WebEvent BizEventToWebEvent(this BizEvent DataEvent)
        {
            WebEvent webEvent = new WebEvent
            {
                Id = DataEvent.Id,
                UserId = DataEvent.UserId,
                RecreationalAreaId = DataEvent.RecreationalAreaId,
                Status = DataEvent.Status,
                StartDate = DataEvent.StartDate,
                EndDate = DataEvent.EndDate,
                StatusName = DataEvent.StatusName,
                Nombre = DataEvent.Nombre,
                AreaName = DataEvent.AreaName,
            };
            return webEvent;
        }

        public static BizEventStatus WebEventStatusToBizEventStatus(this WebEventStatus DataEventStatus)
        {
            BizEventStatus bizEventStatus = new BizEventStatus
            {
                Id = DataEventStatus.Id,
                StatusName = DataEventStatus.StatusName,
                Active = DataEventStatus.Active,
            };
            return bizEventStatus;
        }

        public static WebEventStatus BizEventStatusToWebEventStatus(this BizEventStatus DataEventStatus)
        {
            WebEventStatus webEventStatus = new WebEventStatus
            {
                Id = DataEventStatus.Id,
                StatusName = DataEventStatus.StatusName,
                Active = DataEventStatus.Active,
            };
            return webEventStatus;
        }

        public static BizEventuality WebEventualityToBizEventuality(this WebEventuality DataEventuality)
        {
            BizEventuality bizEventuality = new BizEventuality
            {
                Id = DataEventuality.Id,
                EventualityName = DataEventuality.EventualityName,
                Active = DataEventuality.Active,
            };
            return bizEventuality;
        }

        public static WebEventuality BizEventualityToWebEventuality(this BizEventuality DataEventuality)
        {
            WebEventuality webEventuality = new WebEventuality
            {
                Id = DataEventuality.Id,
                EventualityName = DataEventuality.EventualityName,
                Active = DataEventuality.Active,
            };
            return webEventuality;
        }

        public static BizInternalBox WebInternalBoxToBizInternalBox(this WebInternalBox DataInternalBox)
        {
            BizInternalBox bizInternalBox = new BizInternalBox
            {
                Amount = DataInternalBox.Amount,
                CreationDate = DataInternalBox.CreationDate,
            };
            return bizInternalBox;
        }

        public static WebInternalBox BizInternalBoxToWebInternalBox(this BizInternalBox DataInternalBox)
        {
            WebInternalBox webInternalBox = new WebInternalBox
            {
                Amount = DataInternalBox.Amount,
                CreationDate = DataInternalBox.CreationDate,
            };
            return webInternalBox;
        }

        public static BizInternalExpense WebInternalExpenseToBizInternalExpense(this WebInternalExpense DataInternalExpense)
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

        public static WebInternalExpense BizInternalExpenseToWebInternalExpense(this BizInternalExpense DataInternalExpense)
        {
            WebInternalExpense webInternalExpense = new WebInternalExpense
            {
                Id = DataInternalExpense.Id,
                UserId = DataInternalExpense.UserId,
                Amount = DataInternalExpense.Amount,
                CreationDate = DataInternalExpense.CreationDate,
            };
            return webInternalExpense;
        }

        public static BizPayment WebPaymentToBizPayment(this WebPayment DataPayment)
        {
            BizPayment bizPayment = new BizPayment
            {
                Id = DataPayment.Id,
                UserId = DataPayment.UserId,
                PaymentStatus = DataPayment.PaymentStatus,
                Nombre = DataPayment.Nombre,
                Amount = DataPayment.Amount,
                StatusName = DataPayment.StatusName,
                PaymentDate = DataPayment.PaymentDate,
            };
            return bizPayment;
        }

        public static WebPayment BizPaymentToWebPayment(this BizPayment DataPayment)
        {
            WebPayment webPayment = new WebPayment
            {
                Id = DataPayment.Id,
                UserId = DataPayment.UserId,
                PaymentStatus = DataPayment.PaymentStatus,
                Nombre = DataPayment.Nombre,
                Amount = DataPayment.Amount,
                StatusName = DataPayment.StatusName,
                PaymentDate = DataPayment.PaymentDate,
            };
            return webPayment;
        }

        public static BizPaymentStatus WebPaymentStatusToBizPaymentStatus(this WebPaymentStatus DataPaymentStatus)
        {
            BizPaymentStatus bizPaymentStatus = new BizPaymentStatus
            {
                Id = DataPaymentStatus.Id,
                StatusName = DataPaymentStatus.StatusName,
                Active = DataPaymentStatus.Active,
            };
            return bizPaymentStatus;
        }

        public static WebPaymentStatus BizPaymentStatusToWebPaymentStatus(this BizPaymentStatus DataPaymentStatus)
        {
            WebPaymentStatus webPaymentStatus = new WebPaymentStatus
            {
                Id = DataPaymentStatus.Id,
                StatusName = DataPaymentStatus.StatusName,
                Active = DataPaymentStatus.Active,
            };
            return webPaymentStatus;
        }

        public static BizRecreationalArea WebRecreationalAreaToBizRecreationalArea(this WebRecreationalArea DataRecreationalArea)
        {
            BizRecreationalArea bizRecreationalArea = new BizRecreationalArea
            {
                Id = DataRecreationalArea.Id,
                AreaName = DataRecreationalArea.AreaName,
                Active = DataRecreationalArea.Active,
            };
            return bizRecreationalArea;
        }

        public static WebRecreationalArea BizRecreationalAreaToWebRecreationalArea(this BizRecreationalArea DataRecreationalArea)
        {
            WebRecreationalArea webRecreationalArea = new WebRecreationalArea
            {
                Id = DataRecreationalArea.Id,
                AreaName = DataRecreationalArea.AreaName,
                Active = DataRecreationalArea.Active,
            };
            return webRecreationalArea;
        }

        public static BizSupplier WebSupplierToBizSupplier(this WebSupplier DataSupplier)
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

        public static WebSupplier BizSupplierToWebSupplier(this BizSupplier DataSupplier)
        {
            WebSupplier webSupplier = new WebSupplier
            {
                Id = DataSupplier.Id,
                SupplierName = DataSupplier.SupplierName,
                ContactNumer = DataSupplier.ContactNumer,
                Active = DataSupplier.Active,
            };
            return webSupplier;
        }

        public static BizTicket WebTicketToBizTicket(this WebTicket DataTicket)
        {
            BizTicket bizTicket = new BizTicket
            {
                Id = DataTicket.Id,
                UserId = DataTicket.UserId,
                EventualityId = DataTicket.EventualityId,
                StatusId = DataTicket.StatusId,
                Nombre = DataTicket.Nombre,
                EventualityName = DataTicket.EventualityName,
                StatusName = DataTicket.StatusName,
                CreationDate = DataTicket.CreationDate,
                ModificationDate = DataTicket.ModificationDate,
            };
            return bizTicket;
        }

        public static WebTicket BizTicketToWebTicket(this BizTicket DataTicket)
        {
            WebTicket webTicket = new WebTicket
            {
                Id = DataTicket.Id,
                UserId = DataTicket.UserId,
                EventualityId = DataTicket.EventualityId,
                StatusId = DataTicket.StatusId,
                Nombre = DataTicket.Nombre,
                EventualityName = DataTicket.EventualityName,
                StatusName = DataTicket.StatusName,
                CreationDate = DataTicket.CreationDate,
                ModificationDate = DataTicket.ModificationDate,
            };
            return webTicket;
        }

        public static BizTicketStatus WebTicketStatusToBizTicketStatus(this WebTicketStatus DataTicketStatus)
        {
            BizTicketStatus bizTicketStatus = new BizTicketStatus
            {
                Id = DataTicketStatus.Id,
                StatusName = DataTicketStatus.StatusName,
                Active = DataTicketStatus.Active,
            };
            return bizTicketStatus;
        }

        public static WebTicketStatus BizTicketStatusToWebTicketStatus(this BizTicketStatus DataTicketStatus)
        {
            WebTicketStatus webTicketStatus = new WebTicketStatus
            {
                Id = DataTicketStatus.Id,
                StatusName = DataTicketStatus.StatusName,
                Active = DataTicketStatus.Active,
            };
            return webTicketStatus;
        }

        public static BizTypeCommittee WebTypeCommitteeToBizTypeCommittee(this WebTypeCommittee DataTypeCommittee)
        {
            BizTypeCommittee bizTypeCommittee = new BizTypeCommittee
            {
                Id = DataTypeCommittee.Id,
                TypeCommittee = DataTypeCommittee.TypeCommittee,
                Active = DataTypeCommittee.Active,
            };
            return bizTypeCommittee;
        }

        public static WebTypeCommittee BizTypeCommitteeToWebTypeCommittee(this BizTypeCommittee DataTypeCommittee)
        {
            WebTypeCommittee webTypeCommittee = new WebTypeCommittee
            {
                Id = DataTypeCommittee.Id,
                TypeCommittee = DataTypeCommittee.TypeCommittee,
                Active = DataTypeCommittee.Active,
            };
            return webTypeCommittee;
        }

        public static BizTypeUser WebTypeUserToBizTypeUser(this WebTypeUser DataTypeUser)
        {
            BizTypeUser bizTypeUser = new BizTypeUser
            {
                Id = DataTypeUser.Id,
                TypeUser = DataTypeUser.TypeUser,
                Active = DataTypeUser.Active,
            };
            return bizTypeUser;
        }

        public static WebTypeUser BizTypeUserToWebTypeUser(this BizTypeUser DataTypeUser)
        {
            WebTypeUser webTypeUser = new WebTypeUser
            {
                Id = DataTypeUser.Id,
                TypeUser = DataTypeUser.TypeUser,
                Active = DataTypeUser.Active,
            };
            return webTypeUser;
        }

        public static BizTypeVisit WebTypeVisitToBizTypeVisit(this WebTypeVisit DatTypeVisit)
        {
            BizTypeVisit bizTypeVisit = new BizTypeVisit
            {
                Id = DatTypeVisit.Id,
                TypeVisit = DatTypeVisit.TypeVisit,
                Active = DatTypeVisit.Active,
            };
            return bizTypeVisit;
        }

        public static WebTypeVisit BizTypeVisitToWebTypeVisit(this BizTypeVisit DatTypeVisit)
        {
            WebTypeVisit webTypeVisit = new WebTypeVisit
            {
                Id = DatTypeVisit.Id,
                TypeVisit = DatTypeVisit.TypeVisit,
                Active = DatTypeVisit.Active,
            };
            return webTypeVisit;
        }

        public static BizVehicle WebVehicleToBizVehicle(this WebVehicle DatVehicle)
        {
            BizVehicle bizVehicle = new BizVehicle
            {
                Id = DatVehicle.Id,
                UserId = DatVehicle.UserId,
                Nombre = DatVehicle.Nombre,
                Plates = DatVehicle.Plates,
                Model = DatVehicle.Model,
                Active = DatVehicle.Active,
            };
            return bizVehicle;
        }

        public static WebVehicle BizVehicleToWebVehicle(this BizVehicle DatVehicle)
        {
            WebVehicle webVehicle = new WebVehicle
            {
                Id = DatVehicle.Id,
                UserId = DatVehicle.UserId,
                Nombre = DatVehicle.Nombre,
                Plates = DatVehicle.Plates,
                Model = DatVehicle.Model,
                Active = DatVehicle.Active,
            };
            return webVehicle;
        }

        public static BizVisit WebVisitToBizVisit(this WebVisit DatVisit)
        {
            BizVisit bizVisit = new BizVisit
            {
                Id = DatVisit.Id,
                UserId = DatVisit.UserId,
                VisitId = DatVisit.VisitId,
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

        public static WebVisit BizVisitToWebVisit(this BizVisit DatVisit)
        {
            WebVisit webVisit = new WebVisit
            {
                Id = DatVisit.Id,
                UserId = DatVisit.UserId,
                VisitId = DatVisit.VisitId,
                CheckIn = DatVisit.CheckIn,
                CheckOut = DatVisit.CheckOut,
                VisitName = DatVisit.VisitName,
                Carnet = DatVisit.Carnet,
                Plates = DatVisit.Plates,
                Nombre = DatVisit.Nombre,
                TypeVisit = DatVisit.TypeVisit,
            };
            return webVisit;
        }

        #endregion
    }
}