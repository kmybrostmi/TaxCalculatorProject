using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop_DataAccess.Interface;
public interface ICommandd
{
    void Execute();
    bool CanExecute();
    void Undo();
}

