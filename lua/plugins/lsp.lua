return {
  "neovim/nvim-lspconfig",
  dependencies = {
    "stevearc/conform.nvim",
    "williamboman/mason.nvim",
    "williamboman/mason-lspconfig.nvim",
    "mrcjkb/rustaceanvim",
    "j-hui/fidget.nvim",
    "echasnovski/mini.nvim",
  },
  config = function()
    require("conform").setup({
      formatters_by_ft = {}
    })

    local capabilities = vim.lsp.protocol.make_client_capabilities()
    local keybindings = require("lsp.keybindings")

    require("fidget").setup({})
    require("mason").setup()
    require("mason-lspconfig").setup({
      ensure_installed = {
        "lua_ls",
        "rust_analyzer",
        "gopls",
        "denols",
        "ts-ls",
      },
      handlers = {
        function(server_name)
          if server_name ~= "rust_analyzer" then
            require("lspconfig")[server_name].setup {
              capabilities = capabilities,
              on_attach = keybindings.on_attach,
            }
          end
        end,
        zls = function()
          require("lspconfig").zls.setup({
            root_dir = require("lspconfig").util.root_pattern(".git", "build.zig", "zls.json"),
            settings = {
              zls = {
                enable_inlay_hints = true,
                enable_snippets = true,
                warn_style = true,
              },
            },
            on_attach = keybindings.on_attach,
            capabilities = capabilities,
          })
          vim.g.zig_fmt_parse_errors = 0
          vim.g.zig_fmt_autosave = 0
        end,
        ["lua_ls"] = function()
          require("lspconfig").lua_ls.setup {
            capabilities = capabilities,
            on_attach = keybindings.on_attach,
            settings = {
              Lua = {
                format = {
                  enable = true,
                  defaultConfig = {
                    indent_style = "space",
                    indent_size = "2",
                  }
                },
              }
            }
          }
        end,
        ["denols"] = function()
            require("lspconfig").denols.setup {
                capabilties = capabilities,
                on_attach = keybindings.on_attach,
                root_dir = require("lspconfig").util.root_pattern("deno.json", "deno.jsonc"),
                init_options = {
                    lint = true,
                    unstable = true,
                    suggest = {
                        imports = {
                            hosts = {
                                ["https://deno.land"] = true,
                            },
                        },
                    },
                },
             }
        end,
        },
    })

    require("mini.completion").setup({
      lsp_completion = {
        source_func = "omnifunc",
        auto_setup = true,
        process_items = function(items, base)
          table.sort(items, function(a, b)
            return (a.sort_text or a.label) < (b.sort_text or b.label)
          end)
          return items
        end,
      },
      fallback_action = "<C-x><C-n>",
      mappings = {
        force_twostep = "<C-Space>",
        force_fallback = "<A-Space>",
      },
    })

    require("mini.snippets").setup({
      mappings = {
        trigger = "<C-s>", -- not working
        next = "<C-n>",
        prev = "<C-p>",
        cancel = "<C-c>",
      },
      search_paths = { vim.fn.stdpath("config") .. "/snippets" },
    })

    require("mini.diff").setup({
      view = {
        style = "sign", -- Use sign column for diff markers
        signs = { add = "+", change = "~", delete = "-" },
      },
      mappings = {
        apply = "<leader>hs", -- Stage hunk
        reset = "<leader>hr", -- Reset hunk
        goto_next = "]h", -- Next hunk
        goto_prev = "[h", -- Previous hunk
      },
    })

    vim.diagnostic.config({
      float = {
        focusable = false,
        style = "minimal",
        border = "rounded",
        source = "always",
        header = "",
        prefix = "",
      },
    })
  end
}
