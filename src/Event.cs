using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionGuide;

[TestFixture]
public class EventGuide {
    [Test]
    public void Test() {
        X x = new X();

        using var monitoredSubject = x.Monitor();
        x.Property = 2;
        monitoredSubject.Should().Raise(nameof(X.PropertyChanged))
            .WithSender(x)
            .WithArgs<PropertyChangedEventArgs>(args => args.PropertyName == nameof(X.Property));
    }

    class X : INotifyPropertyChanged {
        int property;

        public X() {
            this.property = 1;
        }
        public int Property {
            get { return property; }
            set {
                if(Property == value) return;
                property = value;
                OnPropertyChanged();
            }
        }

        #region INotifyPropertyChanged
        
        void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
            PropertyChangedEventArgs e = new(propertyName);
            PropertyChanged?.Invoke(this, e);
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion
    }
}