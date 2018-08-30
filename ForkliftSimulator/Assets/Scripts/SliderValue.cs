using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SliderValue
{

    private float _value;
    public float Value
    {
        get
        {
            return _value;
        }
    }
    public float minValue;
    public float maxValue;
    public float initialValue;
    public float inputFactor;
    public delegate void Callback(float value_);
    public Callback callback;

    public void Init() {
        _value = initialValue;
    }

    public void Init(Callback callback_) {
        _value = initialValue;
        callback = callback_;
    }

    public void Update(float input_) {
        if (input_ != 0) {
            if (input_ > 0) {
                if (_value <= maxValue) {
                    _value += input_ * inputFactor;

                    if (callback != null)
                        callback(_value);
                }
            } else {
                if (_value >= minValue) {
                    _value += input_ * inputFactor;

                    if (callback != null)
                        callback(_value);
                }
            }
        }
    }
}
