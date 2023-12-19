import { Navigate } from "react-router-dom";

export const PrivateRoute = ({children, redirectTo = "/"}) => {
    //verificar se está autenticado
    const isAuthenticated = localStorage.getItem("token") !==null;

    //retornar o componente ou navegar parar rome
        return isAuthenticated ? children : <Navigate to={redirectTo}/>
}