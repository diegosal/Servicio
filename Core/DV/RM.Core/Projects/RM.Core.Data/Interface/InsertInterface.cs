using RM.Core.Business.Entities.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Core.Data.Interface
{
    interface InsertInterface
    {
        string InsertTypeUser(BizTypeUser bizTypeUser);
        string InsertTypeCommittee(BizTypeCommittee bizTypeCommittee);
        string InsertTypeVisit(BizTypeVisit bizTypeVisit);
        string InsertRecreationalArea(BizRecreationalArea bizRecreationalArea);
        string InsertEventuality(BizEventuality bizEventuality);
        string InsertStatus(BizStatus bizStatus);
        string InsertSupplier(BizSupplier bizSupplier);
        string InsertCompany(BizCompany bizCompany);
        string InsertUser(BizUser bizUser);
        string InsertVehicle(BizVehicle bizVehicle);
        string InsertAddress(BizAddress bizAddress);
        string InsertCommitteeMember(BizCommitteeMember bizCommitteeMember);
        string InsertEventr(BizEvent bizEvent);
        string InsertTicket(BizTicket bizTicket);
        string InsertVisit(BizVisit bizVisit);
        string InsertAssistControl(BizAssistControl bizAssistControl);
        string InsertPayment(BizPayment bizPayment);
        string InsertInternalBox(BizInternalBox bizInternalBox);
        string InsertInternalExpense(BizInternalExpense bizInternalExpense);
    }
}
