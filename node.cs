﻿namespace node {
    class node<T> {
        T _data;
        node<T> _next = null;
        public T data {
            get {
                return _data;
            }
            set {
                _data = value;
            }
        }
        public node<T> next {
            get {
                return _next;
            }
            set {
                _next = value;
            }
        }

        public node() {
        }

        public node(T data) {
            this.data = data;
        }
    }
}
