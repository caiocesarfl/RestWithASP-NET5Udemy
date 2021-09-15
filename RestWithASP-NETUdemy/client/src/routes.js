import React from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';

import Login from './Pages/Login';
import Books from './Pages/Books';
import NewBook from './Pages/NewBook';

export default function Routes () {
    return (
        <BrowserRouter>
            <Switch>
                <Route path="/" exact component={Login}/>
                <Route path='/books' component={Books}></Route>
                <Route path='/book/new' component={NewBook}></Route>
            </Switch>
        </BrowserRouter> 
    )
}