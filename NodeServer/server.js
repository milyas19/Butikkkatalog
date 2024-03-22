const express = require("express");
const axios = require("axios");
const cors = require("cors");

const app = express();
app.use(cors());
const PORT = 3232;

// Hent endepunkt med paging
app.get("/stores", async (req, res) => {
  try {
    const { page, size } = req.query;
    const pageNumber = parseInt(page) || 1;
    const pageSize = parseInt(size) || 3;

    const response = await axios.get(
      `https://minside.coop.no/StoreService/SearchStores`
    );
    const data = response.data;
    const stores = data.Stores.concat(data.AdditionalStores);

    const startIndex = (pageNumber - 1) * pageSize;
    const endIndex = pageNumber * pageSize;

    const slicedStores = stores.slice(startIndex, endIndex);

    res.json({
      page: pageNumber,
      size: pageSize,
      totalItems: stores.length,
      totalPages: Math.ceil(stores.length / pageSize),
      stores: slicedStores,
    });
  } catch (error) {
    // hvis det er feil så returnere vi feilmeldingen til frontend
    console.error("Error fetching data:", error);
    res.status(500).json({ error: "Error fetching data" });
  }
});

app.listen(PORT, () => {
  console.log(`Server is running on http://localhost:${PORT}`);
});
