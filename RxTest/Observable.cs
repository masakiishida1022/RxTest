using System;
using System.Collections.Generic;
using System.Text;

namespace RxTest
{
    class Observable<T>
    {
        private Action<Observer<T>> subscribe;
        public Observable(Action<Observer<T>> subscribeAction) => this.subscribe = subscribeAction;

        public void Subscribe(Observer<T> observer) => this.subscribe(observer);
    }
}
