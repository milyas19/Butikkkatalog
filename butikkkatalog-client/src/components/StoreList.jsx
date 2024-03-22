/* eslint-disable react/prop-types */
import { useState, useEffect } from "react";
import axios from "axios";
import "./../App.css";
import { LABELS } from "../Contants";

const BaseApiUrl = import.meta.env.VITE_API_URL;

const Card = ({ store }) => {
  return (
    <div className="card">
      <a href={store.NewspaperUrl} className="card-link">
        <h3>
          {LABELS.Coop} {store.Chain} {store.Name}, {store.Name}
        </h3>
        <img
          src={store.ChainImage}
          alt={store.ChainClassName}
          className="store-image"
        />
        {/* <p>{store.Address}</p> */}
        {/* <p>{store.City}</p> */}
        {/* <p>{store.Email}</p> */}
      </a>
      <br />
      {LABELS.InStoreService}
      <span className="inStoreService">
        {store.InStoreServices && <p>{store.InStoreServices.join(", ")}</p>}
      </span>
      {/* <p>{store.OpenNow}</p>
      <p>{store.OpeningHoursToday}</p>
      <p>{store.Phone}</p>
      <p>{store.StoreId}</p> */}
      <p style={{ textAlign: "left" }}>{LABELS.OPENING_HOURS}</p>
      <ul className="opening-hours">
        {store.OpeningHours &&
          store.OpeningHours.map((oh, i) => (
            <li key={i} className={oh.Closed ? "closed" : ""}>
              {oh.Closed
                ? "Stengt"
                : `${oh.Date} ${oh.Day}: ${
                    oh.OpenString.length !== 11
                      ? oh.OpenString.replace(
                          /(\d{2}:\d{2}):\d{2}-(\d{2}:\d{2}):\d{2}/,
                          "$1 - $2"
                        )
                      : oh.OpenString.replace("-", " - ")
                  }`}
            </li>
          ))}
      </ul>
    </div>
  );
};

const StoreList = () => {
  const [stores, setStores] = useState([]);
  const [page, setPage] = useState(1);
  // eslint-disable-next-line no-unused-vars
  const [pageSize, setPageSize] = useState(3);
  const [totalPages, setTotalPages] = useState(0);

  useEffect(() => {
    fetchData();
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [page]);

  const fetchData = async () => {
    try {
      const response = await axios.get(
        `${BaseApiUrl}?page=${page}&size=${pageSize}`
      );
      setStores(response.data.stores);
      setTotalPages(response.data.totalPages);
    } catch (error) {
      console.error("Error fetching data:", error);
    }
  };

  const nextPage = () => {
    setPage(page + 1);
  };

  const prevPage = () => {
    setPage(Math.max(1, page - 1));
  };

  return (
    <div>
      <div className="store-list">
        {stores &&
          stores.map((store) => <Card key={store.StoreId} store={store} />)}
      </div>
      <div className="pagination">
        <button onClick={prevPage} disabled={page === 1}>
          Previous
        </button>
        <span>
          Page {page} of {totalPages}
        </span>
        <button onClick={nextPage} disabled={page === totalPages}>
          Next
        </button>
      </div>
    </div>
  );
};

export default StoreList;
