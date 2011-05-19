//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{

	#region Delegates

	#pragma warning disable
	public delegate void FormOldV10_LoadEventHandler();
	public delegate void FormOldV10_CurrentEventHandler();
	public delegate void FormOldV10_BeforeInsertEventHandler(ref Int16 Cancel);
	public delegate void FormOldV10_AfterInsertEventHandler();
	public delegate void FormOldV10_BeforeUpdateEventHandler(ref Int16 Cancel);
	public delegate void FormOldV10_AfterUpdateEventHandler();
	public delegate void FormOldV10_DeleteEventHandler(ref Int16 Cancel);
	public delegate void FormOldV10_BeforeDelConfirmEventHandler(ref Int16 Cancel, ref Int16 Response);
	public delegate void FormOldV10_AfterDelConfirmEventHandler(ref Int16 Status);
	public delegate void FormOldV10_OpenEventHandler(ref Int16 Cancel);
	public delegate void FormOldV10_ResizeEventHandler();
	public delegate void FormOldV10_UnloadEventHandler(ref Int16 Cancel);
	public delegate void FormOldV10_CloseEventHandler();
	public delegate void FormOldV10_ActivateEventHandler();
	public delegate void FormOldV10_DeactivateEventHandler();
	public delegate void FormOldV10_GotFocusEventHandler();
	public delegate void FormOldV10_LostFocusEventHandler();
	public delegate void FormOldV10_ClickEventHandler();
	public delegate void FormOldV10_DblClickEventHandler(ref Int16 Cancel);
	public delegate void FormOldV10_MouseDownEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void FormOldV10_MouseMoveEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void FormOldV10_MouseUpEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void FormOldV10_KeyDownEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	public delegate void FormOldV10_KeyPressEventHandler(ref Int16 KeyAscii);
	public delegate void FormOldV10_KeyUpEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	public delegate void FormOldV10_ErrorEventHandler(ref Int16 DataErr, ref Int16 Response);
	public delegate void FormOldV10_TimerEventHandler();
	public delegate void FormOldV10_FilterEventHandler(ref Int16 Cancel, ref Int16 FilterType);
	public delegate void FormOldV10_ApplyFilterEventHandler(ref Int16 Cancel, ref Int16 ApplyType);
	public delegate void FormOldV10_DirtyEventHandler(ref Int16 Cancel);
	public delegate void FormOldV10_UndoEventHandler(ref Int16 Cancel);
	public delegate void FormOldV10_RecordExitEventHandler(ref Int16 Cancel);
	public delegate void FormOldV10_BeginBatchEditEventHandler(ref Int16 Cancel);
	public delegate void FormOldV10_UndoBatchEditEventHandler(ref Int16 Cancel);
	public delegate void FormOldV10_BeforeBeginTransactionEventHandler(ref Int16 Cancel, ref NetOffice.ADODBApi.Connection Connection);
	public delegate void FormOldV10_AfterBeginTransactionEventHandler(ref NetOffice.ADODBApi.Connection Connection);
	public delegate void FormOldV10_BeforeCommitTransactionEventHandler(ref Int16 Cancel, ref NetOffice.ADODBApi.Connection Connection);
	public delegate void FormOldV10_AfterCommitTransactionEventHandler(ref NetOffice.ADODBApi.Connection Connection);
	public delegate void FormOldV10_RollbackTransactionEventHandler(ref NetOffice.ADODBApi.Connection Connection);
	public delegate void FormOldV10_OnConnectEventHandler();
	public delegate void FormOldV10_OnDisconnectEventHandler();
	public delegate void FormOldV10_PivotTableChangeEventHandler(Int32 Reason);
	public delegate void FormOldV10_QueryEventHandler();
	public delegate void FormOldV10_BeforeQueryEventHandler();
	public delegate void FormOldV10_SelectionChangeEventHandler();
	public delegate void FormOldV10_CommandBeforeExecuteEventHandler(COMObject Command, COMObject Cancel);
	public delegate void FormOldV10_CommandCheckedEventHandler(COMObject Command, COMObject Checked);
	public delegate void FormOldV10_CommandEnabledEventHandler(COMObject Command, COMObject Enabled);
	public delegate void FormOldV10_CommandExecuteEventHandler(COMObject Command);
	public delegate void FormOldV10_DataSetChangeEventHandler();
	public delegate void FormOldV10_BeforeScreenTipEventHandler(COMObject ScreenTipText, COMObject SourceObject);
	public delegate void FormOldV10_BeforeRenderEventHandler(COMObject drawObject, COMObject chartObject, COMObject Cancel);
	public delegate void FormOldV10_AfterRenderEventHandler(COMObject drawObject, COMObject chartObject);
	public delegate void FormOldV10_AfterFinalRenderEventHandler(COMObject drawObject);
	public delegate void FormOldV10_AfterLayoutEventHandler(COMObject drawObject);
	public delegate void FormOldV10_MouseWheelEventHandler(bool Page, Int32 Count);
	public delegate void FormOldV10_ViewChangeEventHandler(Int32 Reason);
	public delegate void FormOldV10_DataChangeEventHandler(Int32 Reason);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass FormOldV10 SupportByLibrary "Access", 12,14
	///</summary>
	[SupportByLibrary("Access", 12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class FormOldV10 : _Form2, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		_FormEvents_SinkHelper __FormEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FormOldV10(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FormOldV10(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FormOldV10(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public FormOldV10()
		{
			CreateFromProgId("Access.FormOldV10");
		}
		
		/// <param name="progId">progId</param>
		public FormOldV10(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, _FormEvents_SinkHelper.Id);


			if(_FormEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__FormEvents_SinkHelper = new _FormEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_LoadEventHandler _LoadEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_LoadEventHandler LoadEvent
		{
			add
			{
				CreateEventBridge();
				_LoadEvent += value;
			}
			remove
			{
				_LoadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_CurrentEventHandler _CurrentEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_CurrentEventHandler CurrentEvent
		{
			add
			{
				CreateEventBridge();
				_CurrentEvent += value;
			}
			remove
			{
				_CurrentEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_BeforeInsertEventHandler _BeforeInsertEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_BeforeInsertEventHandler BeforeInsertEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeInsertEvent += value;
			}
			remove
			{
				_BeforeInsertEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_AfterInsertEventHandler _AfterInsertEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_AfterInsertEventHandler AfterInsertEvent
		{
			add
			{
				CreateEventBridge();
				_AfterInsertEvent += value;
			}
			remove
			{
				_AfterInsertEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_BeforeUpdateEventHandler _BeforeUpdateEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_BeforeUpdateEventHandler BeforeUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeUpdateEvent += value;
			}
			remove
			{
				_BeforeUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_AfterUpdateEventHandler _AfterUpdateEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_AfterUpdateEventHandler AfterUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_AfterUpdateEvent += value;
			}
			remove
			{
				_AfterUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_DeleteEventHandler _DeleteEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_DeleteEventHandler DeleteEvent
		{
			add
			{
				CreateEventBridge();
				_DeleteEvent += value;
			}
			remove
			{
				_DeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_BeforeDelConfirmEventHandler _BeforeDelConfirmEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_BeforeDelConfirmEventHandler BeforeDelConfirmEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeDelConfirmEvent += value;
			}
			remove
			{
				_BeforeDelConfirmEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_AfterDelConfirmEventHandler _AfterDelConfirmEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_AfterDelConfirmEventHandler AfterDelConfirmEvent
		{
			add
			{
				CreateEventBridge();
				_AfterDelConfirmEvent += value;
			}
			remove
			{
				_AfterDelConfirmEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_OpenEventHandler _OpenEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_OpenEventHandler OpenEvent
		{
			add
			{
				CreateEventBridge();
				_OpenEvent += value;
			}
			remove
			{
				_OpenEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_ResizeEventHandler _ResizeEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_ResizeEventHandler ResizeEvent
		{
			add
			{
				CreateEventBridge();
				_ResizeEvent += value;
			}
			remove
			{
				_ResizeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_UnloadEventHandler _UnloadEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_UnloadEventHandler UnloadEvent
		{
			add
			{
				CreateEventBridge();
				_UnloadEvent += value;
			}
			remove
			{
				_UnloadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_CloseEventHandler _CloseEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_CloseEventHandler CloseEvent
		{
			add
			{
				CreateEventBridge();
				_CloseEvent += value;
			}
			remove
			{
				_CloseEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_ActivateEventHandler _ActivateEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_ActivateEventHandler ActivateEvent
		{
			add
			{
				CreateEventBridge();
				_ActivateEvent += value;
			}
			remove
			{
				_ActivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_DeactivateEventHandler _DeactivateEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_DeactivateEventHandler DeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_DeactivateEvent += value;
			}
			remove
			{
				_DeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_GotFocusEventHandler _GotFocusEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_GotFocusEventHandler GotFocusEvent
		{
			add
			{
				CreateEventBridge();
				_GotFocusEvent += value;
			}
			remove
			{
				_GotFocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_LostFocusEventHandler _LostFocusEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_LostFocusEventHandler LostFocusEvent
		{
			add
			{
				CreateEventBridge();
				_LostFocusEvent += value;
			}
			remove
			{
				_LostFocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_DblClickEventHandler DblClickEvent
		{
			add
			{
				CreateEventBridge();
				_DblClickEvent += value;
			}
			remove
			{
				_DblClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_KeyDownEventHandler KeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_KeyDownEvent += value;
			}
			remove
			{
				_KeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_KeyPressEventHandler KeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_KeyPressEvent += value;
			}
			remove
			{
				_KeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_KeyUpEventHandler KeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_KeyUpEvent += value;
			}
			remove
			{
				_KeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_ErrorEventHandler _ErrorEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_ErrorEventHandler ErrorEvent
		{
			add
			{
				CreateEventBridge();
				_ErrorEvent += value;
			}
			remove
			{
				_ErrorEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_TimerEventHandler _TimerEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_TimerEventHandler TimerEvent
		{
			add
			{
				CreateEventBridge();
				_TimerEvent += value;
			}
			remove
			{
				_TimerEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_FilterEventHandler _FilterEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_FilterEventHandler FilterEvent
		{
			add
			{
				CreateEventBridge();
				_FilterEvent += value;
			}
			remove
			{
				_FilterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_ApplyFilterEventHandler _ApplyFilterEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_ApplyFilterEventHandler ApplyFilterEvent
		{
			add
			{
				CreateEventBridge();
				_ApplyFilterEvent += value;
			}
			remove
			{
				_ApplyFilterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9 10 11 12 14
		/// </summary>
		private event FormOldV10_DirtyEventHandler _DirtyEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOldV10_DirtyEventHandler DirtyEvent
		{
			add
			{
				CreateEventBridge();
				_DirtyEvent += value;
			}
			remove
			{
				_DirtyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_UndoEventHandler _UndoEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_UndoEventHandler UndoEvent
		{
			add
			{
				CreateEventBridge();
				_UndoEvent += value;
			}
			remove
			{
				_UndoEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_RecordExitEventHandler _RecordExitEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_RecordExitEventHandler RecordExitEvent
		{
			add
			{
				CreateEventBridge();
				_RecordExitEvent += value;
			}
			remove
			{
				_RecordExitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_BeginBatchEditEventHandler _BeginBatchEditEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_BeginBatchEditEventHandler BeginBatchEditEvent
		{
			add
			{
				CreateEventBridge();
				_BeginBatchEditEvent += value;
			}
			remove
			{
				_BeginBatchEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_UndoBatchEditEventHandler _UndoBatchEditEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_UndoBatchEditEventHandler UndoBatchEditEvent
		{
			add
			{
				CreateEventBridge();
				_UndoBatchEditEvent += value;
			}
			remove
			{
				_UndoBatchEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_BeforeBeginTransactionEventHandler _BeforeBeginTransactionEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_BeforeBeginTransactionEventHandler BeforeBeginTransactionEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeBeginTransactionEvent += value;
			}
			remove
			{
				_BeforeBeginTransactionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_AfterBeginTransactionEventHandler _AfterBeginTransactionEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_AfterBeginTransactionEventHandler AfterBeginTransactionEvent
		{
			add
			{
				CreateEventBridge();
				_AfterBeginTransactionEvent += value;
			}
			remove
			{
				_AfterBeginTransactionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_BeforeCommitTransactionEventHandler _BeforeCommitTransactionEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_BeforeCommitTransactionEventHandler BeforeCommitTransactionEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeCommitTransactionEvent += value;
			}
			remove
			{
				_BeforeCommitTransactionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_AfterCommitTransactionEventHandler _AfterCommitTransactionEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_AfterCommitTransactionEventHandler AfterCommitTransactionEvent
		{
			add
			{
				CreateEventBridge();
				_AfterCommitTransactionEvent += value;
			}
			remove
			{
				_AfterCommitTransactionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_RollbackTransactionEventHandler _RollbackTransactionEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_RollbackTransactionEventHandler RollbackTransactionEvent
		{
			add
			{
				CreateEventBridge();
				_RollbackTransactionEvent += value;
			}
			remove
			{
				_RollbackTransactionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_OnConnectEventHandler _OnConnectEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_OnConnectEventHandler OnConnectEvent
		{
			add
			{
				CreateEventBridge();
				_OnConnectEvent += value;
			}
			remove
			{
				_OnConnectEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_OnDisconnectEventHandler _OnDisconnectEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_OnDisconnectEventHandler OnDisconnectEvent
		{
			add
			{
				CreateEventBridge();
				_OnDisconnectEvent += value;
			}
			remove
			{
				_OnDisconnectEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_PivotTableChangeEventHandler _PivotTableChangeEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_PivotTableChangeEventHandler PivotTableChangeEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableChangeEvent += value;
			}
			remove
			{
				_PivotTableChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_QueryEventHandler _QueryEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_QueryEventHandler QueryEvent
		{
			add
			{
				CreateEventBridge();
				_QueryEvent += value;
			}
			remove
			{
				_QueryEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_BeforeQueryEventHandler _BeforeQueryEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_BeforeQueryEventHandler BeforeQueryEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeQueryEvent += value;
			}
			remove
			{
				_BeforeQueryEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_SelectionChangeEventHandler _SelectionChangeEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_SelectionChangeEventHandler SelectionChangeEvent
		{
			add
			{
				CreateEventBridge();
				_SelectionChangeEvent += value;
			}
			remove
			{
				_SelectionChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_CommandBeforeExecuteEventHandler _CommandBeforeExecuteEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_CommandBeforeExecuteEventHandler CommandBeforeExecuteEvent
		{
			add
			{
				CreateEventBridge();
				_CommandBeforeExecuteEvent += value;
			}
			remove
			{
				_CommandBeforeExecuteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_CommandCheckedEventHandler _CommandCheckedEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_CommandCheckedEventHandler CommandCheckedEvent
		{
			add
			{
				CreateEventBridge();
				_CommandCheckedEvent += value;
			}
			remove
			{
				_CommandCheckedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_CommandEnabledEventHandler _CommandEnabledEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_CommandEnabledEventHandler CommandEnabledEvent
		{
			add
			{
				CreateEventBridge();
				_CommandEnabledEvent += value;
			}
			remove
			{
				_CommandEnabledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_CommandExecuteEventHandler _CommandExecuteEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_CommandExecuteEventHandler CommandExecuteEvent
		{
			add
			{
				CreateEventBridge();
				_CommandExecuteEvent += value;
			}
			remove
			{
				_CommandExecuteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_DataSetChangeEventHandler _DataSetChangeEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_DataSetChangeEventHandler DataSetChangeEvent
		{
			add
			{
				CreateEventBridge();
				_DataSetChangeEvent += value;
			}
			remove
			{
				_DataSetChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_BeforeScreenTipEventHandler _BeforeScreenTipEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_BeforeScreenTipEventHandler BeforeScreenTipEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeScreenTipEvent += value;
			}
			remove
			{
				_BeforeScreenTipEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_BeforeRenderEventHandler _BeforeRenderEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_BeforeRenderEventHandler BeforeRenderEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeRenderEvent += value;
			}
			remove
			{
				_BeforeRenderEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_AfterRenderEventHandler _AfterRenderEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_AfterRenderEventHandler AfterRenderEvent
		{
			add
			{
				CreateEventBridge();
				_AfterRenderEvent += value;
			}
			remove
			{
				_AfterRenderEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_AfterFinalRenderEventHandler _AfterFinalRenderEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_AfterFinalRenderEventHandler AfterFinalRenderEvent
		{
			add
			{
				CreateEventBridge();
				_AfterFinalRenderEvent += value;
			}
			remove
			{
				_AfterFinalRenderEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_AfterLayoutEventHandler _AfterLayoutEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_AfterLayoutEventHandler AfterLayoutEvent
		{
			add
			{
				CreateEventBridge();
				_AfterLayoutEvent += value;
			}
			remove
			{
				_AfterLayoutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_MouseWheelEventHandler _MouseWheelEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_MouseWheelEventHandler MouseWheelEvent
		{
			add
			{
				CreateEventBridge();
				_MouseWheelEvent += value;
			}
			remove
			{
				_MouseWheelEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_ViewChangeEventHandler _ViewChangeEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_ViewChangeEventHandler ViewChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ViewChangeEvent += value;
			}
			remove
			{
				_ViewChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10 11 12 14
		/// </summary>
		private event FormOldV10_DataChangeEventHandler _DataChangeEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOldV10_DataChangeEventHandler DataChangeEvent
		{
			add
			{
				CreateEventBridge();
				_DataChangeEvent += value;
			}
			remove
			{
				_DataChangeEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != __FormEvents_SinkHelper)
			{
				__FormEvents_SinkHelper.Dispose();
				__FormEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}