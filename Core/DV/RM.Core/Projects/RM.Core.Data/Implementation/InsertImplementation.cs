using RM.Core.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RM.Core.Business.Entities.Views;
using RM.Core.Data.Biz;

namespace RM.Core.Data.Implementation
{
    public class InsertImplementation : BizLogic, InsertInterface
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
            throw new NotImplementedException();
        }

        public string InsertCommitteeMember(BizCommitteeMember bizCommitteeMember)
        {
            throw new NotImplementedException();
        }

        public string InsertCompany(BizCompany bizCompany)
        {
            throw new NotImplementedException();
        }

        public string InsertEventr(BizEvent bizEvent)
        {
            throw new NotImplementedException();
        }

        public string InsertEventuality(BizEventuality bizEventuality)
        {
            throw new NotImplementedException();
        }

        public string InsertInternalBox(BizInternalBox bizInternalBox)
        {
            throw new NotImplementedException();
        }

        public string InsertInternalExpense(BizInternalExpense bizInternalExpense)
        {
            throw new NotImplementedException();
        }

        public string InsertPayment(BizPayment bizPayment)
        {
            throw new NotImplementedException();
        }

        public string InsertRecreationalArea(BizRecreationalArea bizRecreationalArea)
        {
            throw new NotImplementedException();
        }

        public string InsertStatus(BizStatus bizStatus)
        {
            throw new NotImplementedException();
        }

        public string InsertSupplier(BizSupplier bizSupplier)
        {
            throw new NotImplementedException();
        }

        public string InsertTicket(BizTicket bizTicket)
        {
            throw new NotImplementedException();
        }

        public string InsertTypeCommittee(BizTypeCommittee bizTypeCommittee)
        {
            throw new NotImplementedException();
        }

        public string InsertTypeUser(BizTypeUser bizTypeUser)
        {
            throw new NotImplementedException();
        }

        public string InsertTypeVisit(BizTypeVisit bizTypeVisit)
        {
            throw new NotImplementedException();
        }

        public string InsertUser(BizUser bizUser)
        {
            throw new NotImplementedException();
        }

        public string InsertVehicle(BizVehicle bizVehicle)
        {
            throw new NotImplementedException();
        }

        public string InsertVisit(BizVisit bizVisit)
        {
            throw new NotImplementedException();
        }
    }
}
