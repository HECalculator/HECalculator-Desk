using System;

public class Validations
{
    public Validations(States states)
    {
        this.States = states;
    }

    public States States { get => States; set => States = value; }

    double? inputValidationEmptyW(string value)
    {
        if (Double.TryParse(value, out double parsedValue))
        {
            if (value == null || isLessThenZero(parsedValue) == true)
            {
                States.Message.Add("Input empty or less than zero.");
                return null;
            }
            return parsedValue;
        }
        States.Message.Add("Input has to be a numeric type.");
        return null;
    }

    double? inputValidationMatYield(string value)
    {
        if (Double.TryParse(value, out double parsedValue))
        {
            if (value == null)
            {
                States.Message.Add("Input empty.");
                return null;
            }
            if (isLessThenZero(parsedValue) == true)
            {
                States.Message.Add("Input less than zero.");
                return null;
            }
            return parsedValue;
        }
        States.Message.Add("Input has to be a numeric type.");
        return null;
    }

    double? inputValidationImpactFac(string value)
    {
        if (Double.TryParse(value, out double parsedValue))
        {
            if (value == null || isLessThenZero(parsedValue) == true)
            {
                States.Message.Add("Input empty or less than zero.");
                return null;
            }
            return parsedValue;
        }
        States.Message.Add("Input has to be a numeric type.");
        return null;
    }


    // geometry validation
    /// <summary>
    /// Giga-method for validating geometry prior to executing calculation.
    /// Tracks errors and populates the States class with a list of errors to display to the user.
    /// </summary>
    /// <param name="inputs"></param>
    void validateGeometry(Inputs inputs)
    {

        if (validateHoleFromBottom(inputs.LlHoleDia, inputs.LlODOffToHole))
        {
            States.Message.Add("Lifting lug height not sufficient due to hole diameter.");
        };
        if (validateHoleFromSides(inputs.LlHoleDia, inputs.LlWidth))
        {
            States.Message.Add("Lifting lug width not sufficient due to hole diameter.");
        };
        if (validateArcRadius(inputs.LlHoleDia, inputs.LlSCArcRad))
        {
            States.Message.Add("Lifting lug semi-circular arc not sufficient due to hole diameter.");
        };
        if (validateImpactFac(inputs.ImpactFac))
        {
            States.Message.Add("Impact factor is less than 1.");
        };

    }



    // helpers

    /// <summary>
    /// Used to check if input is a value less than zero.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>True if less than 0.</returns>
    private bool isLessThenZero(double value)
    {
        if (value < 0)
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Used to verify that the lug has any material between the hole and lug sides.
    /// </summary>
    /// <param name="LlHoleDia"></param>
    /// <param name="LlWidth"></param>
    /// <returns>True if the lug has any material between the hole and the sides.</returns>
    private bool validateHoleFromSides(double LlHoleDia, double LlWidth)
    {
        if (LlHoleDia > LlWidth)
        {
            return false;
        }
        return true;
    }

    /// <summary>
    /// Used to verify that the lug has any material between the hole and the bottom of the lug.
    /// </summary>
    /// <param name="LlHoleDia"></param>
    /// <param name="LlODOffToHole"></param>
    /// <returns>True if the lug has any material between the hole and the bottom.</returns>
    private bool validateHoleFromBottom(double LlHoleDia, double LlODOffToHole)
    {
        if (LlHoleDia / 2 > LlODOffToHole)
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// Used to verify that there is material between the hole and lug se,i-circular arc.
    /// </summary>
    /// <param name="LlHoleDia"></param>
    /// <param name="LlSCArcRad"></param>
    /// <returns>True if the lug has any material between the hole and the semi-circular arc.</returns>
    private bool validateArcRadius(double LlHoleDia, double LlSCArcRad)
    {
        if (LlHoleDia >= LlSCArcRad / 2)
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// Used to verify that the impact factor is 1 or above.
    /// </summary>
    /// <param name="ImpactFac"></param>
    /// <returns></returns>
    private bool validateImpactFac(double ImpactFac)
    {
        if (ImpactFac < 1)
        {
            return false;
        }

        return true;
    }
}
