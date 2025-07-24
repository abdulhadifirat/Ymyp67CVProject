using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Ymyp67CVProjectEntity.Concrete;

public  sealed class Skill : BaseEntity
{
    public string Title { get; set; }
    public bool IsProgramLanguageAndTools { get; set; }
    public string Icon { get; set; }
    public int MyProperty { get; set; }

}
