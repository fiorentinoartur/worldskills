import React from 'react';
import { BrowserRouter, Route , Routes} from 'react-router-dom';
import Header from "../Components/Header/Header"
import Footer from "../Components/Footer/Footer";
import HomePage from '../Pages/HomePage/HomePage';
import ResultsPage from '../Pages/ResultsPage/ResultsPage';
import { PrivateRoute } from './privateRoute';
import LoginPage from '../Pages/LoginPage/LoginPage';
const Rotas = () => {
    return (
        <BrowserRouter>
                <Header/>
                <Routes>

          <Route element={<HomePage/>} path='/'/>

          <Route
          path='/resultado'
          element={
          <PrivateRoute redirectTo='/'>
              <ResultsPage/>
          </PrivateRoute>
          }/>

          <Route
          element={<LoginPage/>}
          path='/login'
          />
                </Routes>
                <Footer/>
        </BrowserRouter>
    );
};

export default Rotas;