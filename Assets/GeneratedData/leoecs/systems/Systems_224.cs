using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System224 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component376,Component230,Component236> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component179>())
   {
    entity.Del<Component179>();
   }
   else
   {
    entity.Replace(new Component179());
   }
  }
 }
}

}
