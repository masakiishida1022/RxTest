using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxTest
{
    class Observer<T>
    {
        private Action<T> onNextAction;
        public Observer(Action<T> onNext) => this.onNextAction = onNext;

        public void onNext(T v) => this.onNextAction.Invoke(v);

    }
}
