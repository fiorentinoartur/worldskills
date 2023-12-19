import React from 'react';
import './TableRe.css';
import editPen from '../../../Assets/Icons/edit-pen.svg'
import trashDelete from '../../../Assets/Icons/trash-delete.svg'
const TableRe = () => {
    return (
        <table className="table-data">
      <thead className="table-data__head">
        <tr className="table-data__head-row">
          <th className="table-data__head-title table-data__head-title--big">
           Rank
          </th>
          <th className="table-data__head-title table-data__head-title--big">
            Medalha
          </th>
          <th className="table-data__head-title table-data__head-title--big">
            Competidor
          </th>
          <th className="table-data__head-title table-data__head-title--big">
            Pontos
          </th>
          <th className="table-data__head-title table-data__head-title--big">
            País
          </th>
          <th className="table-data__head-title table-data__head-title--little">
            Editar
          </th>
          <th className="table-data__head-title table-data__head-title--little">
            Deletar
          </th>
        </tr>
      </thead>
      <tbody>
        
          {/* return ( */}
            <tr className="table-data__head-row">
              <td className="table-data__data table-data__data--big">
              1ª
              </td>
              <td
                className="table-data__data table-data__data--big table-data__data--handover"
                data-tooltip-id="description-tooltip"
                // data-tooltip-content={tp.descricao}
                data-tooltip-place="top"
              >
          Ouro
              </td>
              <td className="table-data__data table-data__data--big">
             Gustavo
              </td>
              <td className="table-data__data table-data__data--big">
               734
              </td>
              <td className="table-data__data table-data__data--big">
               Brasil
              </td>

              <td className="table-data__data table-data__data--little">
                <img
                  className="table-data__icon"
                //   idevento={tp.idEvento}
                  src={editPen}
                  alt=""
                //   onClick={(e) =>
                //     // dá pra passar o obhjeto tp direto?
                //     fnUpdate({//showUpdateForma(??)
                //       idEvento: tp.idEvento,
                //       nomeEvento: tp.nomeEvento,
                //       dataEvento: tp.dataEvento,
                //       descricao: tp.descricao,
                //       idInstituicao: tp.idInstituicao, //por enquanto chumbado
                //       idTipoEvento: tp.idTipoEvento
                //     })
                //   }
                />
              </td>

              <td className="table-data__data table-data__data--little">
                <img
                  className="table-data__icon"
                //   idevento={tp.idEvento}
                  src={trashDelete}
                  alt=""
                //   onClick={(e) => fnDelete(e.target.getAttribute("idEvento"))}
                />
              </td>
            </tr>
          {/* ); */}
     
      </tbody>
    </table>

    );
};

export default TableRe;