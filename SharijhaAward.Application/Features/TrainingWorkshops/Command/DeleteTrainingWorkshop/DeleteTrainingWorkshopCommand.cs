﻿using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Command.DeleteTrainingWorkshop
{
    public class DeleteTrainingWorkshopCommand :IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
