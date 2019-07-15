using CRUD.DAL.Models;
using CRUD.DAL.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD.BLL.Repository;

namespace A4AeroaCRUD.Controllers
{
    public class AgentManagementController : Controller
    {
        private CRUDBunisnessLogicRep _repository;

        public AgentManagementController()
        {
            _repository = new CRUDBunisnessLogicRep();
        }

        // GET: AgentManagement
        public ActionResult Index()
        {
            var agentList           =   _repository.getAllAgent(null, null, null);
            var viewComponents      =   _repository.getAllVMComponentList();
            ViewBag.MarkUpPlanList  =   viewComponents.MarkUpPlanList;

            return View(agentList);
        }

        [HttpGet]
        public ActionResult AddEditAgentInfo(int? AgentInfoId = null)
        {
            var agentInfo           =   _repository.getAgentById(AgentInfoId);
            var viewComponents      =   _repository.getAllVMComponentList();

            ViewBag.AgentTypeList = viewComponents.AgnetTypeList;
            ViewBag.FlightApiList = viewComponents.FlightApiList;
            ViewBag.StatusList = viewComponents.StatusList;
            ViewBag.MarkUpPlanList = viewComponents.MarkUpPlanList;

            return View(agentInfo);
        }

        [HttpPost]
        public ActionResult AddEditAgentInfo(AgentInfoModel agent, int[] Flights)
        {
            _repository.AddAgent(agent, Flights);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteAgent(int? AgentInfoId)
        {
            _repository.deleteAgent(AgentInfoId);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult SearchAgent(string AgentCode, string AgentName, int? MarkUpPlan)
        {
            var agentList = _repository.getAllAgent(AgentCode, AgentName, MarkUpPlan);

            return View("AgentList", agentList);
        }
    }
}