import React from 'react';
/*
react-dev-inspector:
  This package allows users to jump to local IDE code directly from browser React component by just a simple click, 
  which is similar to Chrome inspector but more advanced.
*/
import { Inspector } from 'react-dev-inspector';

/*
React.Fragment:
  A common pattern in React is for a component to return multiple elements. 
  Fragments let you group a list of children without adding extra nodes to the DOM.
process.env.NODE_ENV:
  Read value of NODE_ENV from environment variable of the local computer.
*/
const InspectorWrapper = process.env.NODE_ENV === 'development' ? Inspector : React.Fragment;

const Layout: React.FC = ({ children }) => {
  return <InspectorWrapper>{children}</InspectorWrapper>;
};

export default Layout;
