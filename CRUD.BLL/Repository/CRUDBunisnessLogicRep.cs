using CRUD.DAL.Models.Context;
using CRUD.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.BLL.Repository
{
    public class CRUDBunisnessLogicRep
    {
        private CRUDDBContext _db;

        public CRUDBunisnessLogicRep()
        {
            _db = new CRUDDBContext();
        }

        public IList<AgentInfoModel> getAllAgent(string AgentCode, string AgentName, int? MarkUpPlan)
        {
            return _db.AgentInfoModels.Where(m => 
                        (m.AgentCode.Contains(AgentCode) || AgentCode == null) &&
                        (m.AgentName.Contains(AgentName) || AgentName == null) &&
                        (m.MarkUpPlanId == MarkUpPlan || MarkUpPlan == null) &&
                        (m.IsDeleted == false)).ToList();
        }

        public AgentInfoModel getAgentById(int? AgentInfoId)
        {
            var agentInfo = new AgentInfoModel();
            if (AgentInfoId != null)
            {
                agentInfo = _db.AgentInfoModels.Where(m => 
                                m.AgentInfoId == AgentInfoId &&
                                m.IsDeleted == false).FirstOrDefault();
            }
            return agentInfo;
        }

        public void AddAgent(AgentInfoModel Agent, int[] Flights)
        {
            if (Agent.AgentInfoId == 0)
            {
                Agent.IsDeleted = false;
                _db.AgentInfoModels.Add(Agent);
                _db.SaveChanges();
            }
            else
                _updateAgent(Agent);

            _addFlightByAgent(Agent.AgentInfoId, Flights);
        }

        private void _addFlightByAgent(int AgentId, int[] Flights)
        {
            foreach (var flightId in Flights)
            {
                var agentFlight         =   new AgentWithFlightAPIS();
                agentFlight.AgentInfoId =   AgentId;
                agentFlight.FlightAPIId =   flightId;
                agentFlight.IsDeleted   =   false;

                _db.AgentWithFlightAPISs.Add(agentFlight);
                _db.SaveChanges();
            }
        }

        public void deleteAgent(int? AgentInfoId)
        {
            var agentInfo = getAgentById(AgentInfoId);
            agentInfo.IsDeleted = true;
            _db.SaveChanges();
            _deleteFlightsByAgent(agentInfo.AgentInfoId);
        }

        private void _deleteFlightsByAgent(int AgentInfoId)
        {
            var existFlightAPILIst = _db.AgentWithFlightAPISs.Where(m => m.AgentInfoId == AgentInfoId && m.IsDeleted == false).ToList();

            if (existFlightAPILIst.Count > 0)
            {
                foreach (var item in existFlightAPILIst)
                {
                    item.IsDeleted = true;
                    _db.SaveChanges();
                }
            }
        }

        private void _updateAgent(AgentInfoModel agent)
        {
            var existAgent = getAgentById(agent.AgentInfoId);
            if (existAgent != null)
            {
                existAgent.AgentCode      =    agent.AgentCode;
                existAgent.AgentName      =    agent.AgentName;
                existAgent.MarkUpPlanId   =    agent.MarkUpPlanId;
                existAgent.Email          =    agent.Email;
                existAgent.Mobile         =    agent.Mobile;
                existAgent.Phone          =    agent.Phone;
                existAgent.Address        =    agent.Address;
                existAgent.City           =    agent.City;
                existAgent.State          =    agent.State;
                existAgent.PostCode       =    agent.PostCode;
                existAgent.JoiningDate    =    agent.JoiningDate;
                existAgent.AgentTypes     =    agent.AgentTypes;
                existAgent.Balance        =    agent.Balance;
                existAgent.FlightAPIS     =    agent.FlightAPIS;
                existAgent.Status         =    agent.Status;
                existAgent.IsDeleted      =    false;

                _deleteFlightsByAgent(existAgent.AgentInfoId);
            }
        }

        public CustomViewModel getAllVMComponentList()
        {
            var components              =   new CustomViewModel();
            components.MarkUpPlanList   =   _db.MarkUpPlans.ToList();
            return components;
        }
    }
}
