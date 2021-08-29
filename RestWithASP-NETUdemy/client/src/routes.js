import React from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';

import Login from './Pages/Login';
import Book from './Pages/Book';

export default function Routes () {
    return (
        <BrowserRouter>
            <Switch>
                <Route path="/" exact component={Login}/>
                <Route path='/Book' component={Book}></Route>
            </Switch>
        </BrowserRouter> 
    )
}