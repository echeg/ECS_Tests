using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System207 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component145,Component425,Component293,Component39> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component132>())
   {
    entity.Del<Component132>();
   }
   else
   {
    entity.Replace(new Component132());
   }
  }
 }
}

}
