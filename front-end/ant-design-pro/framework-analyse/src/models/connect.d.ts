import type { MenuDataItem, Settings as ProSettings } from '@ant-design/pro-layout';
import { GlobalModelState } from './GlobalViewModel';
import { UserModelState } from './UserViewModel';
import type { LoginStateType } from '@/modeltypes/Login';

export { GlobalModelState, UserModelState };

// Declare type for dva-loading plugin.
export type Loading = {
  global: boolean;
  effects: Record<string, boolean | undefined>;
  models: {
    global?: boolean;
    menu?: boolean;
    setting?: boolean;
    user?: boolean;
    login?: boolean;
  };
};

export type ConnectState = {
  global: GlobalModelState;
  loading: Loading;
  settings: ProSettings;
  user: UserModelState;
  login: LoginStateType;
};

export type Route = {
  routes?: Route[];
} & MenuDataItem;
