﻿using JustAProgrammer.TeamPilgrim.VisualStudio.Domain.BusinessInterfaces;
using JustAProgrammer.TeamPilgrim.VisualStudio.Providers;

namespace JustAProgrammer.TeamPilgrim.VisualStudio.Model.Explorer
{
    public class ReportsModel : BaseModel
    {
        public ReportsModel(IPilgrimServiceModelProvider pilgrimServiceModelProvider, ITeamPilgrimVsService teamPilgrimVsService)
            : base(pilgrimServiceModelProvider, teamPilgrimVsService)
        {
        }
    }
}