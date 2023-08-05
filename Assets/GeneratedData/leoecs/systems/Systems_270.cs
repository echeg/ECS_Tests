using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System270 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component105,Component201,Component129> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component446>())
   {
    q+=1;
    var com = entity.Get<Component446>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component284>())
   {
    q+=1;
    var com = entity.Get<Component284>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component179>())
   {
    q+=1;
    var com = entity.Get<Component179>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component496>())
   {
    q+=1;
    var com = entity.Get<Component496>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
