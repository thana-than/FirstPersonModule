//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""FirstPerson"",
            ""id"": ""63793024-5f2e-4699-85da-712081cca53a"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ac10deb5-a70a-4bb1-bd33-03c8874750fe"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""3bbad3bd-18d1-44e1-89b7-35c998ca8394"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""1a0be340-5e99-4d8d-9c6c-2f307eac47a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""bd7a428b-9277-48a9-ade4-afd65681a841"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""fdb48bd2-c323-4fce-b8e2-99ae1cfb4d09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""cfd1d0e0-a751-48c0-88f6-c99fa8b793da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""a871481f-ea13-4283-b570-7f7b294edd1d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""3b1fe715-8e6a-49f1-8f55-ce6889b7e482"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchWeapon"",
                    ""type"": ""Value"",
                    ""id"": ""805d0b35-e11e-44c5-9a8b-ccd73bae9e16"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""5c48e314-d3c4-4060-9391-7cb1d03640ea"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ad9d698e-ef45-4067-8e52-977057eb928f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6c5c60ad-1bb8-4f2f-aa88-740a7ce32a6e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ad1e52b1-629a-462b-a093-50eb886d6120"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bba9027e-a219-4978-8586-face11df7389"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""134855da-b262-44b0-b5a3-34ab7874b7de"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12c4f0fb-48be-466d-b7ac-b8cd32e56f15"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30b289c5-d304-4147-8957-8125f47e3254"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e265874-40ab-42bc-b74e-a64c7b2b65da"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5042fbd7-f962-4348-bfd7-320c9df2676e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e7c9d11-13d8-4b36-b9cb-4aeb31df17c3"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd076a4a-0009-43a1-bcda-5d79edaf5d73"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard Gamepad"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a174dd2f-b078-4d14-8dc3-1a6d457d280e"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58cf733c-fbb7-47b2-abfa-84e194f80a28"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbfa83f6-94a7-4012-9b2b-f0e76432578d"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1975e574-0980-42a7-8bea-61dcd2e565d6"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard Gamepad"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c3e2178-8c6d-4381-be6c-ad1a9e4f609b"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5b16b36-8ede-44da-8020-8093e2848a7f"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard Gamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc76dc85-4b8e-40b8-acbf-6ac96e1430cf"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c45d9be-92b7-404b-b3d7-48a20026c6e8"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard Gamepad"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7088b105-2f7f-46fc-b04b-d572b762b441"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""SwitchWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Shoulder Buttons"",
                    ""id"": ""ca7b0fdf-771f-40d7-a2a2-b71744464e88"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchWeapon"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""644ae12e-3719-4aab-8092-9109cd0e8e20"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard Gamepad"",
                    ""action"": ""SwitchWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""631353f2-48f1-42c4-92cf-a2411fba3067"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard Gamepad"",
                    ""action"": ""SwitchWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Standard Gamepad"",
            ""bindingGroup"": ""Standard Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // FirstPerson
        m_FirstPerson = asset.FindActionMap("FirstPerson", throwIfNotFound: true);
        m_FirstPerson_Move = m_FirstPerson.FindAction("Move", throwIfNotFound: true);
        m_FirstPerson_Look = m_FirstPerson.FindAction("Look", throwIfNotFound: true);
        m_FirstPerson_Shoot = m_FirstPerson.FindAction("Shoot", throwIfNotFound: true);
        m_FirstPerson_Aim = m_FirstPerson.FindAction("Aim", throwIfNotFound: true);
        m_FirstPerson_Jump = m_FirstPerson.FindAction("Jump", throwIfNotFound: true);
        m_FirstPerson_Sprint = m_FirstPerson.FindAction("Sprint", throwIfNotFound: true);
        m_FirstPerson_Crouch = m_FirstPerson.FindAction("Crouch", throwIfNotFound: true);
        m_FirstPerson_Reload = m_FirstPerson.FindAction("Reload", throwIfNotFound: true);
        m_FirstPerson_SwitchWeapon = m_FirstPerson.FindAction("SwitchWeapon", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // FirstPerson
    private readonly InputActionMap m_FirstPerson;
    private IFirstPersonActions m_FirstPersonActionsCallbackInterface;
    private readonly InputAction m_FirstPerson_Move;
    private readonly InputAction m_FirstPerson_Look;
    private readonly InputAction m_FirstPerson_Shoot;
    private readonly InputAction m_FirstPerson_Aim;
    private readonly InputAction m_FirstPerson_Jump;
    private readonly InputAction m_FirstPerson_Sprint;
    private readonly InputAction m_FirstPerson_Crouch;
    private readonly InputAction m_FirstPerson_Reload;
    private readonly InputAction m_FirstPerson_SwitchWeapon;
    public struct FirstPersonActions
    {
        private @Controls m_Wrapper;
        public FirstPersonActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_FirstPerson_Move;
        public InputAction @Look => m_Wrapper.m_FirstPerson_Look;
        public InputAction @Shoot => m_Wrapper.m_FirstPerson_Shoot;
        public InputAction @Aim => m_Wrapper.m_FirstPerson_Aim;
        public InputAction @Jump => m_Wrapper.m_FirstPerson_Jump;
        public InputAction @Sprint => m_Wrapper.m_FirstPerson_Sprint;
        public InputAction @Crouch => m_Wrapper.m_FirstPerson_Crouch;
        public InputAction @Reload => m_Wrapper.m_FirstPerson_Reload;
        public InputAction @SwitchWeapon => m_Wrapper.m_FirstPerson_SwitchWeapon;
        public InputActionMap Get() { return m_Wrapper.m_FirstPerson; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FirstPersonActions set) { return set.Get(); }
        public void SetCallbacks(IFirstPersonActions instance)
        {
            if (m_Wrapper.m_FirstPersonActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnLook;
                @Shoot.started -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnShoot;
                @Aim.started -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnAim;
                @Jump.started -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnJump;
                @Sprint.started -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnSprint;
                @Crouch.started -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnCrouch;
                @Reload.started -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnReload;
                @SwitchWeapon.started -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnSwitchWeapon;
                @SwitchWeapon.performed -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnSwitchWeapon;
                @SwitchWeapon.canceled -= m_Wrapper.m_FirstPersonActionsCallbackInterface.OnSwitchWeapon;
            }
            m_Wrapper.m_FirstPersonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @SwitchWeapon.started += instance.OnSwitchWeapon;
                @SwitchWeapon.performed += instance.OnSwitchWeapon;
                @SwitchWeapon.canceled += instance.OnSwitchWeapon;
            }
        }
    }
    public FirstPersonActions @FirstPerson => new FirstPersonActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    private int m_StandardGamepadSchemeIndex = -1;
    public InputControlScheme StandardGamepadScheme
    {
        get
        {
            if (m_StandardGamepadSchemeIndex == -1) m_StandardGamepadSchemeIndex = asset.FindControlSchemeIndex("Standard Gamepad");
            return asset.controlSchemes[m_StandardGamepadSchemeIndex];
        }
    }
    public interface IFirstPersonActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnSwitchWeapon(InputAction.CallbackContext context);
    }
}