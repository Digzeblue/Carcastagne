// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControls : IInputActionCollection
{
    private InputActionAsset asset;
    public PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""df936a38-ad41-4ddd-b2dd-e143c0e82806"",
            ""actions"": [
                {
                    ""name"": ""Move right"",
                    ""id"": ""a3506571-5ee6-4387-b21e-6d17b82cda65"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Move left"",
                    ""id"": ""3f82589d-cc40-4385-9e2f-62d0bbf0654f"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ad718ad2-870d-4008-8fd7-6b5128fd26e8"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""6629f6db-ba87-4d01-aff3-54a21d498b23"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.GetActionMap("Gameplay");
        m_Gameplay_Moveright = m_Gameplay.GetAction("Move right");
        m_Gameplay_Moveleft = m_Gameplay.GetAction("Move left");
    }

    ~PlayerControls()
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

    public ReadOnlyArray<InputControlScheme> controlSchemes
    {
        get => asset.controlSchemes;
    }

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

    // Gameplay
    private InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private InputAction m_Gameplay_Moveright;
    private InputAction m_Gameplay_Moveleft;
    public struct GameplayActions
    {
        private PlayerControls m_Wrapper;
        public GameplayActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moveright { get { return m_Wrapper.m_Gameplay_Moveright; } }
        public InputAction @Moveleft { get { return m_Wrapper.m_Gameplay_Moveleft; } }
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                Moveright.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveright;
                Moveright.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveright;
                Moveright.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveright;
                Moveleft.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveleft;
                Moveleft.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveleft;
                Moveleft.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveleft;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                Moveright.started += instance.OnMoveright;
                Moveright.performed += instance.OnMoveright;
                Moveright.canceled += instance.OnMoveright;
                Moveleft.started += instance.OnMoveleft;
                Moveleft.performed += instance.OnMoveleft;
                Moveleft.canceled += instance.OnMoveleft;
            }
        }
    }
    public GameplayActions @Gameplay
    {
        get
        {
            return new GameplayActions(this);
        }
    }
    public interface IGameplayActions
    {
        void OnMoveright(InputAction.CallbackContext context);
        void OnMoveleft(InputAction.CallbackContext context);
    }
}
