using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    interface ICalculatorPresenter
    {
        /**
     * Вызывается формой в тот момент, когда пользователь нажал на кнопку '+'
     */
        void onPlusClicked();

        /**
         * Вызывается формой в тот момент, когда пользователь нажал на кнопку '-'
         */
        void onMinusClicked();

        /**
         * Вызывается формой в тот момент, когда пользователь нажал на кнопку '/'
         */
        void onDivideClicked();

        /**
         * Вызывается формой в тот момент, когда пользователь нажал на кнопку '*'
         */
        void onMultiplyClicked();
    }
}
