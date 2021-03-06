using BulbaCourses.Youtube.Logic.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulbaCourses.Youtube.Logic.Validator
{
    public class ResultVideoValidator : AbstractValidator<ResultVideo>
    {
        string[] _definition = { "High", "Standard", "Any" };
        string[] _dimension = { "Value2d", "Value3d", "Any" };
        string[] _duration = { "Long__", "Medium", "Short__", "Any" };
        string[] _videoCaption = { "ClosedCaption", "None", "Any" };

        public ResultVideoValidator()
        {
            RuleFor(v => v.Id).NotNull().WithMessage("Id must be not null");
            RuleFor(v => v.Title).NotNull().MaximumLength(500)
                .WithMessage("Title must be not null, length no more than 500 symbols");
            RuleFor(v => v.PublishedAt).NotNull().WithMessage("PublishedAt must be not null");
            RuleFor(x => x.Definition).Must(x => !string.IsNullOrEmpty(x))
                .Must(x => _definition.Any(d => d == x))
                .WithMessage("Definition must be not null and must be one of three values: High, Standard, Any");
            RuleFor(x => x.Dimension).Must(x => !string.IsNullOrEmpty(x))
                .Must(x => _dimension.Any(d => d == x))
                .WithMessage("Dimension must be not null and must be one of three values: Value2d, Value3d, Any");
            RuleFor(x => x.Duration).Must(x => !string.IsNullOrEmpty(x))
                .Must(x => _duration.Any(d => d == x))
                .WithMessage("Duration must be not null and must be one of four values: Long__, Medium, Short__, Any");
            RuleFor(x => x.VideoCaption).Must(x => !string.IsNullOrEmpty(x))
                .Must(x => _videoCaption.Any(v => v == x))
                .WithMessage("VideoCaption must be not null and must be one of three values: ClosedCaption, None, Any");
            RuleFor(v => v.Thumbnail).NotNull();
        }
    }
}
