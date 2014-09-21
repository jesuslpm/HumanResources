using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResources.WindowsForms
{
    public static class BindingExtensions
    {

        public static void UpdateEntityFromControls(this Control container, object entity)
        {
            if (container == null) throw new ArgumentNullException("container");
            if (entity == null) throw new ArgumentNullException("entity");
            Type entityType = entity.GetType();
            Type containerType = container.GetType();

            foreach (var pi in entityType.GetProperties().Where( x => x.CanWrite))
            {
                var controlMember = containerType.GetField(pi.Name + "Control", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (controlMember != null)
                {
                    Control control = (Control)controlMember.GetValue(container);
                   
                    DateTimePicker picker = control as DateTimePicker;
                    if (picker != null && pi.CanWrite)
                    {
                        pi.SetValue(entity, picker.Value);
                    }
                    else
                    {
                        string text = control.Text == null ? null : control.Text.Trim();
                        if (text == string.Empty) text = null;
                        pi.SetValue(entity, Convert.ChangeType(text, pi.PropertyType));
                    }
                }
            }
        }


        public static void ShowEntity(this Control container, object entity )
        {
            if (container == null) throw new ArgumentNullException("container");
            if (entity == null) throw new ArgumentNullException("entity");
            Type entityType = entity.GetType();
            Type containerType = container.GetType();

            foreach (var pi in entityType.GetProperties())
            {
                var controlMember = containerType.GetField(pi.Name + "Control", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (controlMember != null)
                {
                    Control control = (Control)controlMember.GetValue(container);

                    object propertyValue = pi.GetValue(entity);
                    DateTimePicker picker = control as DateTimePicker;
                    if (picker != null)
                    {
                        picker.Value = Convert.ToDateTime(propertyValue);
                    }
                    else
                    {
                        control.Text = Convert.ToString(propertyValue);
                    }
                }
            }
        }

        public static void ShowErrors(this Control container, ErrorProvider errorProvider, Type entityType, ValidationResult validationResults)
        {
            foreach (var pi in entityType.GetProperties())
            {
                var controlProperty = container.GetType().GetField(pi.Name + "Control", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (controlProperty != null)
                {
                    errorProvider.SetError((Control)controlProperty.GetValue(container),
                        string.Join(", ", validationResults.Errors.Where(x => x.PropertyName == pi.Name)
                        .Select(x => x.ErrorMessage)));
                }
            }
        }
    }
}
