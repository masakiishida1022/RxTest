using System;
using System.Collections.Generic;
using System.Text;

namespace RxTest
{
    class Observer<T>
    {
        private Action<T> onNextAction;
        public Observer(Action<T> action) => this.onNextAction = action;

        public void onNext(T v) => this.onNextAction.Invoke(v);
    }
}
