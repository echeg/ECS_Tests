using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System273 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component258,Component129,Component484> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component211>())
   {
    entity.Del<Component211>();
   }
   else
   {
    entity.Replace(new Component211());
   }
  }
 }
}

}
