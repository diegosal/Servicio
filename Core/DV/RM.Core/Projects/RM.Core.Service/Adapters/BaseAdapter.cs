using RM.Core.Business.Entities.Views;
using RM.Core.Web.Entities.Views;
using System.Collections.Generic;

namespace RM.Core.Service.Adapters
{
    /// <summary>
    /// Class BaseAdapter.
    /// </summary>
    public static class BaseAdapter
    {
        #region OBJECT-LIST

        /// <summary>
        /// Lists the biz user to list web user.
        /// </summary>
        /// <param name="DataUserList">The data user list.</param>
        /// <returns>List&lt;WebUser&gt;.</returns>
        public static List<WebUser> ListBizUserToListWebUser(this List<BizUser> DataUserList)
        {
            List<WebUser> WebUserList = new List<WebUser>();

            foreach (BizUser dataUser in DataUserList)
            {
                WebUserList.Add(dataUser.BizUserToWebUser());
            }

            return WebUserList;
        }

        /// <summary>
        /// Lists the biz address to list web address.
        /// </summary>
        /// <param name="DataAddressList">The data address list.</param>
        /// <returns>List&lt;WebAddress&gt;.</returns>
        public static List<WebAddress> ListBizAddressToListWebAddress(this List<BizAddress> DataAddressList)
        {
            List<WebAddress> WebAddressList = new List<WebAddress>();

            foreach (BizAddress dataAddress in DataAddressList)
            {
                WebAddressList.Add(dataAddress.BizAddressToWebAddress());
            }

            return WebAddressList;
        }

        /// <summary>
        /// Lists the biz assist control to list web assist control.
        /// </summary>
        /// <param name="DataAssistControlList">The data assist control list.</param>
        /// <returns>List&lt;WebAssistControl&gt;.</returns>
        public static List<WebAssistControl> ListBizAssistControlToListWebAssistControl(this List<BizAssistControl> DataAssistControlList)
        {
            List<WebAssistControl> WebAssistControlList = new List<WebAssistControl>();

            foreach (BizAssistControl dataAssistControl in DataAssistControlList)
            {
                WebAssistControlList.Add(dataAssistControl.BizAssistControlToWebAssistControl());
            }

            return WebAssistControlList;
        }

        /// <summary>
        /// Lists the biz committee member to list web committee member.
        /// </summary>
        /// <param name="DataCommitteeMemberList">The data committee member list.</param>
        /// <returns>List&lt;WebCommitteeMember&gt;.</returns>
        public static List<WebCommitteeMember> ListBizCommitteeMemberToListWebCommitteeMember(this List<BizCommitteeMember> DataCommitteeMemberList)
        {
            List<WebCommitteeMember> WebCommitteeMemberList = new List<WebCommitteeMember>();

            foreach (BizCommitteeMember dataCommitteeMember in DataCommitteeMemberList)
            {
                WebCommitteeMemberList.Add(dataCommitteeMember.BizCommitteeMemberToWebCommitteeMember());
            }

            return WebCommitteeMemberList;
        }

        /// <summary>
        /// Lists the biz company to list web company.
        /// </summary>
        /// <param name="DataCompanyList">The data company list.</param>
        /// <returns>List&lt;WebCompany&gt;.</returns>
        public static List<WebCompany> ListBizCompanyToListWebCompany(this List<BizCompany> DataCompanyList)
        {
            List<WebCompany> WebCompanyList = new List<WebCompany>();

            foreach (BizCompany dataCompany in DataCompanyList)
            {
                WebCompanyList.Add(dataCompany.BizCompanyToWebCompany());
            }

            return WebCompanyList;
        }

        /// <summary>
        /// Lists the biz event to list web event.
        /// </summary>
        /// <param name="DataEventList">The data event list.</param>
        /// <returns>List&lt;WebEvent&gt;.</returns>
        public static List<WebEvent> ListBizEventToListWebEvent(this List<BizEvent> DataEventList)
        {
            List<WebEvent> WebEventList = new List<WebEvent>();

            foreach (BizEvent dataEvent in DataEventList)
            {
                WebEventList.Add(dataEvent.BizEventToWebEvent());
            }

            return WebEventList;
        }

        /// <summary>
        /// Lists the biz event status to list web event status.
        /// </summary>
        /// <param name="DataEventStatusList">The data event status list.</param>
        /// <returns>List&lt;WebEventStatus&gt;.</returns>
        public static List<WebEventStatus> ListBizEventStatusToListWebEventStatus(this List<BizEventStatus> DataEventStatusList)
        {
            List<WebEventStatus> WebEventStatusList = new List<WebEventStatus>();

            foreach (BizEventStatus dataEventStatus in DataEventStatusList)
            {
                WebEventStatusList.Add(dataEventStatus.BizEventStatusToWebEventStatus());
            }

            return WebEventStatusList;
        }

        /// <summary>
        /// Lists the biz a eventuality to list web eventuality.
        /// </summary>
        /// <param name="DataEventualityList">The data eventuality list.</param>
        /// <returns>List&lt;WebEventuality&gt;.</returns>
        public static List<WebEventuality> ListBizAEventualityToListWebEventuality(this List<BizEventuality> DataEventualityList)
        {
            List<WebEventuality> WebEventualityList = new List<WebEventuality>();

            foreach (BizEventuality dataEventuality in DataEventualityList)
            {
                WebEventualityList.Add(dataEventuality.BizEventualityToWebEventuality());
            }

            return WebEventualityList;
        }

        /// <summary>
        /// Lists the biz internal box to list web internal box.
        /// </summary>
        /// <param name="DataInternalBoxList">The data internal box list.</param>
        /// <returns>List&lt;WebInternalBox&gt;.</returns>
        public static List<WebInternalBox> ListBizInternalBoxToListWebInternalBox(this List<BizInternalBox> DataInternalBoxList)
        {
            List<WebInternalBox> WebInternalBoxList = new List<WebInternalBox>();

            foreach (BizInternalBox dataInternalBox in DataInternalBoxList)
            {
                WebInternalBoxList.Add(dataInternalBox.BizInternalBoxToWebInternalBox());
            }

            return WebInternalBoxList;
        }

        /// <summary>
        /// Lists the biz internal expense to list web internal expense.
        /// </summary>
        /// <param name="DataInternalExpenseList">The data internal expense list.</param>
        /// <returns>List&lt;WebInternalExpense&gt;.</returns>
        public static List<WebInternalExpense> ListBizInternalExpenseToListWebInternalExpense(this List<BizInternalExpense> DataInternalExpenseList)
        {
            List<WebInternalExpense> WebInternalExpenseList = new List<WebInternalExpense>();

            foreach (BizInternalExpense dataInternalExpense in DataInternalExpenseList)
            {
                WebInternalExpenseList.Add(dataInternalExpense.BizInternalExpenseToWebInternalExpense());
            }

            return WebInternalExpenseList;
        }

        /// <summary>
        /// Lists the biz payment to list web payment.
        /// </summary>
        /// <param name="DataPaymentList">The data payment list.</param>
        /// <returns>List&lt;WebPayment&gt;.</returns>
        public static List<WebPayment> ListBizPaymentToListWebPayment(this List<BizPayment> DataPaymentList)
        {
            List<WebPayment> WebPaymentList = new List<WebPayment>();

            foreach (BizPayment dataPayment in DataPaymentList)
            {
                WebPaymentList.Add(dataPayment.BizPaymentToWebPayment());
            }

            return WebPaymentList;
        }

        /// <summary>
        /// Lists the biz payment status to list web payment status.
        /// </summary>
        /// <param name="DataPaymentStatusList">The data payment status list.</param>
        /// <returns>List&lt;WebPaymentStatus&gt;.</returns>
        public static List<WebPaymentStatus> ListBizPaymentStatusToListWebPaymentStatus(this List<BizPaymentStatus> DataPaymentStatusList)
        {
            List<WebPaymentStatus> WebPaymentStatusList = new List<WebPaymentStatus>();

            foreach (BizPaymentStatus dataPaymentStatus in DataPaymentStatusList)
            {
                WebPaymentStatusList.Add(dataPaymentStatus.BizPaymentStatusToWebPaymentStatus());
            }

            return WebPaymentStatusList;
        }

        /// <summary>
        /// Lists the biz recreational area to list web recreational area.
        /// </summary>
        /// <param name="DataRecreationalAreaList">The data recreational area list.</param>
        /// <returns>List&lt;WebRecreationalArea&gt;.</returns>
        public static List<WebRecreationalArea> ListBizRecreationalAreaToListWebRecreationalArea(this List<BizRecreationalArea> DataRecreationalAreaList)
        {
            List<WebRecreationalArea> WebRecreationalAreaList = new List<WebRecreationalArea>();

            foreach (BizRecreationalArea dataRecreationalArea in DataRecreationalAreaList)
            {
                WebRecreationalAreaList.Add(dataRecreationalArea.BizRecreationalAreaToWebRecreationalArea());
            }

            return WebRecreationalAreaList;
        }

        /// <summary>
        /// Lists the biz supplier to list web supplier.
        /// </summary>
        /// <param name="DataSupplierList">The data supplier list.</param>
        /// <returns>List&lt;WebSupplier&gt;.</returns>
        public static List<WebSupplier> ListBizSupplierToListWebSupplier(this List<BizSupplier> DataSupplierList)
        {
            List<WebSupplier> WebSupplierList = new List<WebSupplier>();

            foreach (BizSupplier dataSupplier in DataSupplierList)
            {
                WebSupplierList.Add(dataSupplier.BizSupplierToWebSupplier());
            }

            return WebSupplierList;
        }

        /// <summary>
        /// Lists the biz ticket to list web ticket.
        /// </summary>
        /// <param name="DataTicketList">The data ticket list.</param>
        /// <returns>List&lt;WebTicket&gt;.</returns>
        public static List<WebTicket> ListBizTicketToListWebTicket(this List<BizTicket> DataTicketList)
        {
            List<WebTicket> WebTicketList = new List<WebTicket>();

            foreach (BizTicket dataTicket in DataTicketList)
            {
                WebTicketList.Add(dataTicket.BizTicketToWebTicket());
            }

            return WebTicketList;
        }

        /// <summary>
        /// Lists the biz ticket status to list web ticket status.
        /// </summary>
        /// <param name="DataTicketStatusList">The data ticket status list.</param>
        /// <returns>List&lt;WebTicketStatus&gt;.</returns>
        public static List<WebTicketStatus> ListBizTicketStatusToListWebTicketStatus(this List<BizTicketStatus> DataTicketStatusList)
        {
            List<WebTicketStatus> WebTicketStatusList = new List<WebTicketStatus>();

            foreach (BizTicketStatus dataTicketStatus in DataTicketStatusList)
            {
                WebTicketStatusList.Add(dataTicketStatus.BizTicketStatusToWebTicketStatus());
            }

            return WebTicketStatusList;
        }

        /// <summary>
        /// Lists the biz type committee to list web type committee.
        /// </summary>
        /// <param name="DataTypeCommitteeList">The data type committee list.</param>
        /// <returns>List&lt;WebTypeCommittee&gt;.</returns>
        public static List<WebTypeCommittee> ListBizTypeCommitteeToListWebTypeCommittee(this List<BizTypeCommittee> DataTypeCommitteeList)
        {
            List<WebTypeCommittee> WebTypeCommitteeList = new List<WebTypeCommittee>();

            foreach (BizTypeCommittee dataTypeCommittee in DataTypeCommitteeList)
            {
                WebTypeCommitteeList.Add(dataTypeCommittee.BizTypeCommitteeToWebTypeCommittee());
            }

            return WebTypeCommitteeList;
        }

        /// <summary>
        /// Lists the biz type user to list web type user.
        /// </summary>
        /// <param name="DataTypeUserList">The data type user list.</param>
        /// <returns>List&lt;WebTypeUser&gt;.</returns>
        public static List<WebTypeUser> ListBizTypeUserToListWebTypeUser(this List<BizTypeUser> DataTypeUserList)
        {
            List<WebTypeUser> WebTypeUserList = new List<WebTypeUser>();

            foreach (BizTypeUser dataTypeUser in DataTypeUserList)
            {
                WebTypeUserList.Add(dataTypeUser.BizTypeUserToWebTypeUser());
            }

            return WebTypeUserList;
        }

        /// <summary>
        /// Lists the biz type visit to list web type visit.
        /// </summary>
        /// <param name="DataTypeVisitList">The data type visit list.</param>
        /// <returns>List&lt;WebTypeVisit&gt;.</returns>
        public static List<WebTypeVisit> ListBizTypeVisitToListWebTypeVisit(this List<BizTypeVisit> DataTypeVisitList)
        {
            List<WebTypeVisit> WebTypeVisitList = new List<WebTypeVisit>();

            foreach (BizTypeVisit dataTypeVisit in DataTypeVisitList)
            {
                WebTypeVisitList.Add(dataTypeVisit.BizTypeVisitToWebTypeVisit());
            }

            return WebTypeVisitList;
        }

        /// <summary>
        /// Lists the biz vehicle to list web vehicle.
        /// </summary>
        /// <param name="DataVehicleList">The data vehicle list.</param>
        /// <returns>List&lt;WebVehicle&gt;.</returns>
        public static List<WebVehicle> ListBizVehicleToListWebVehicle(this List<BizVehicle> DataVehicleList)
        {
            List<WebVehicle> WebVehicleList = new List<WebVehicle>();

            foreach (BizVehicle dataVehicle in DataVehicleList)
            {
                WebVehicleList.Add(dataVehicle.BizVehicleToWebVehicle());
            }

            return WebVehicleList;
        }

        /// <summary>
        /// Lists the biz visit to list web visit.
        /// </summary>
        /// <param name="DataVisitList">The data visit list.</param>
        /// <returns>List&lt;WebVisit&gt;.</returns>
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

        /// <summary>
        /// Webs the user to biz user.
        /// </summary>
        /// <param name="DataUser">The data user.</param>
        /// <returns>BizUser.</returns>
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

        /// <summary>
        /// Bizs the user to web user.
        /// </summary>
        /// <param name="DataUser">The data user.</param>
        /// <returns>WebUser.</returns>
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

        /// <summary>
        /// Webs the address to biz address.
        /// </summary>
        /// <param name="DataAddress">The data address.</param>
        /// <returns>BizAddress.</returns>
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

        /// <summary>
        /// Bizs the address to web address.
        /// </summary>
        /// <param name="DataAddress">The data address.</param>
        /// <returns>WebAddress.</returns>
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

        /// <summary>
        /// Webs the assist control to biz assist control.
        /// </summary>
        /// <param name="DataAssistControl">The data assist control.</param>
        /// <returns>BizAssistControl.</returns>
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

        /// <summary>
        /// Bizs the assist control to web assist control.
        /// </summary>
        /// <param name="DataAssistControl">The data assist control.</param>
        /// <returns>WebAssistControl.</returns>
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

        /// <summary>
        /// Webs the committee member to biz committee member.
        /// </summary>
        /// <param name="DataCommitteeMember">The data committee member.</param>
        /// <returns>BizCommitteeMember.</returns>
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

        /// <summary>
        /// Bizs the committee member to web committee member.
        /// </summary>
        /// <param name="DataCommitteeMember">The data committee member.</param>
        /// <returns>WebCommitteeMember.</returns>
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

        /// <summary>
        /// Webs the company to biz company.
        /// </summary>
        /// <param name="DataCompany">The data company.</param>
        /// <returns>BizCompany.</returns>
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

        /// <summary>
        /// Bizs the company to web company.
        /// </summary>
        /// <param name="DataCompany">The data company.</param>
        /// <returns>WebCompany.</returns>
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

        /// <summary>
        /// Bizs the event to web event.
        /// </summary>
        /// <param name="DataEvent">The data event.</param>
        /// <returns>BizEvent.</returns>
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

        /// <summary>
        /// Bizs the event to web event.
        /// </summary>
        /// <param name="DataEvent">The data event.</param>
        /// <returns>WebEvent.</returns>
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

        /// <summary>
        /// Webs the event status to biz event status.
        /// </summary>
        /// <param name="DataEventStatus">The data event status.</param>
        /// <returns>BizEventStatus.</returns>
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

        /// <summary>
        /// Bizs the event status to web event status.
        /// </summary>
        /// <param name="DataEventStatus">The data event status.</param>
        /// <returns>WebEventStatus.</returns>
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

        /// <summary>
        /// Webs the eventuality to biz eventuality.
        /// </summary>
        /// <param name="DataEventuality">The data eventuality.</param>
        /// <returns>BizEventuality.</returns>
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

        /// <summary>
        /// Bizs the eventuality to web eventuality.
        /// </summary>
        /// <param name="DataEventuality">The data eventuality.</param>
        /// <returns>WebEventuality.</returns>
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

        /// <summary>
        /// Webs the internal box to biz internal box.
        /// </summary>
        /// <param name="DataInternalBox">The data internal box.</param>
        /// <returns>BizInternalBox.</returns>
        public static BizInternalBox WebInternalBoxToBizInternalBox(this WebInternalBox DataInternalBox)
        {
            BizInternalBox bizInternalBox = new BizInternalBox
            {
                Amount = DataInternalBox.Amount,
                CreationDate = DataInternalBox.CreationDate,
            };
            return bizInternalBox;
        }

        /// <summary>
        /// Bizs the internal box to web internal box.
        /// </summary>
        /// <param name="DataInternalBox">The data internal box.</param>
        /// <returns>WebInternalBox.</returns>
        public static WebInternalBox BizInternalBoxToWebInternalBox(this BizInternalBox DataInternalBox)
        {
            WebInternalBox webInternalBox = new WebInternalBox
            {
                Amount = DataInternalBox.Amount,
                CreationDate = DataInternalBox.CreationDate,
            };
            return webInternalBox;
        }

        /// <summary>
        /// Webs the internal expense to biz internal expense.
        /// </summary>
        /// <param name="DataInternalExpense">The data internal expense.</param>
        /// <returns>BizInternalExpense.</returns>
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

        /// <summary>
        /// Bizs the internal expense to web internal expense.
        /// </summary>
        /// <param name="DataInternalExpense">The data internal expense.</param>
        /// <returns>WebInternalExpense.</returns>
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

        /// <summary>
        /// Webs the payment to biz payment.
        /// </summary>
        /// <param name="DataPayment">The data payment.</param>
        /// <returns>BizPayment.</returns>
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

        /// <summary>
        /// Bizs the payment to web payment.
        /// </summary>
        /// <param name="DataPayment">The data payment.</param>
        /// <returns>WebPayment.</returns>
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

        /// <summary>
        /// Webs the payment status to biz payment status.
        /// </summary>
        /// <param name="DataPaymentStatus">The data payment status.</param>
        /// <returns>BizPaymentStatus.</returns>
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

        /// <summary>
        /// Bizs the payment status to web payment status.
        /// </summary>
        /// <param name="DataPaymentStatus">The data payment status.</param>
        /// <returns>WebPaymentStatus.</returns>
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

        /// <summary>
        /// Webs the recreational area to biz recreational area.
        /// </summary>
        /// <param name="DataRecreationalArea">The data recreational area.</param>
        /// <returns>BizRecreationalArea.</returns>
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

        /// <summary>
        /// Bizs the recreational area to web recreational area.
        /// </summary>
        /// <param name="DataRecreationalArea">The data recreational area.</param>
        /// <returns>WebRecreationalArea.</returns>
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

        /// <summary>
        /// Webs the supplier to biz supplier.
        /// </summary>
        /// <param name="DataSupplier">The data supplier.</param>
        /// <returns>BizSupplier.</returns>
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

        /// <summary>
        /// Bizs the supplier to web supplier.
        /// </summary>
        /// <param name="DataSupplier">The data supplier.</param>
        /// <returns>WebSupplier.</returns>
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

        /// <summary>
        /// Webs the ticket to biz ticket.
        /// </summary>
        /// <param name="DataTicket">The data ticket.</param>
        /// <returns>BizTicket.</returns>
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

        /// <summary>
        /// Bizs the ticket to web ticket.
        /// </summary>
        /// <param name="DataTicket">The data ticket.</param>
        /// <returns>WebTicket.</returns>
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

        /// <summary>
        /// Webs the ticket status to biz ticket status.
        /// </summary>
        /// <param name="DataTicketStatus">The data ticket status.</param>
        /// <returns>BizTicketStatus.</returns>
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

        /// <summary>
        /// Bizs the ticket status to web ticket status.
        /// </summary>
        /// <param name="DataTicketStatus">The data ticket status.</param>
        /// <returns>WebTicketStatus.</returns>
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

        /// <summary>
        /// Webs the type committee to biz type committee.
        /// </summary>
        /// <param name="DataTypeCommittee">The data type committee.</param>
        /// <returns>BizTypeCommittee.</returns>
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

        /// <summary>
        /// Bizs the type committee to web type committee.
        /// </summary>
        /// <param name="DataTypeCommittee">The data type committee.</param>
        /// <returns>WebTypeCommittee.</returns>
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

        /// <summary>
        /// Webs the type user to biz type user.
        /// </summary>
        /// <param name="DataTypeUser">The data type user.</param>
        /// <returns>BizTypeUser.</returns>
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

        /// <summary>
        /// Bizs the type user to web type user.
        /// </summary>
        /// <param name="DataTypeUser">The data type user.</param>
        /// <returns>WebTypeUser.</returns>
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

        /// <summary>
        /// Webs the type visit to biz type visit.
        /// </summary>
        /// <param name="DatTypeVisit">The dat type visit.</param>
        /// <returns>BizTypeVisit.</returns>
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

        /// <summary>
        /// Bizs the type visit to web type visit.
        /// </summary>
        /// <param name="DatTypeVisit">The dat type visit.</param>
        /// <returns>WebTypeVisit.</returns>
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

        /// <summary>
        /// Webs the vehicle to biz vehicle.
        /// </summary>
        /// <param name="DatVehicle">The dat vehicle.</param>
        /// <returns>BizVehicle.</returns>
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

        /// <summary>
        /// Bizs the vehicle to web vehicle.
        /// </summary>
        /// <param name="DatVehicle">The dat vehicle.</param>
        /// <returns>WebVehicle.</returns>
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

        /// <summary>
        /// Webs the visit to biz visit.
        /// </summary>
        /// <param name="DatVisit">The dat visit.</param>
        /// <returns>BizVisit.</returns>
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

        /// <summary>
        /// Bizs the visit to web visit.
        /// </summary>
        /// <param name="DatVisit">The dat visit.</param>
        /// <returns>WebVisit.</returns>
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