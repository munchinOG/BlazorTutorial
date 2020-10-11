﻿using Microsoft.AspNetCore.Components.Forms;

namespace EmployeeManagement.Web.Pages
{
    public class CustomInputSelect<TValue> : InputSelect<TValue>
    {
        protected override bool TryParseValueFromString( string value, out TValue result,
            out string validationErrorMessage )
        {
            if(typeof( TValue ) == typeof( int ))
            {
                if(int.TryParse( value, out var resultInt ))
                {
                    result = (TValue)(object)resultInt;
                    validationErrorMessage = null;
                    return true;
                }
                else
                {
                    result = default;
                    validationErrorMessage =
                        $"The select value {value} is not a valid number.";
                    return false;
                }
            }
            //else if(typeof( TValue ) == typeof( Guid ))
            //{
            //    if(Guid.TryParse( value, out var resultGuid ))
            //    {
            //        result = (TValue)(object)resultGuid;
            //        validationErrorMessage = null;
            //        return true;
            //    }
            //    else
            //    {
            //        result = default;
            //        validationErrorMessage =
            //            $"The select value {value} is not a valid number.";
            //        return false;
            //    }
            //}
            else
            {
                return base.TryParseValueFromString( value, out result, out validationErrorMessage );
            }
        }
    }
}
