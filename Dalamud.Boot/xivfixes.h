#pragma once

namespace xivfixes {
    void unhook_dll(bool bApply);
    void prevent_devicechange_crashes(bool bApply);
    void disable_game_openprocess_access_check(bool bApply);
    void redirect_openprocess(bool bApply);

    void apply_all(bool bApply);
}
