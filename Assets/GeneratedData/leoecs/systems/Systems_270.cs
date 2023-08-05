using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System270 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component454,Component331,Component387> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component57>())
   {
    q+=1;
    var com = entity.Get<Component57>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component136>())
   {
    q+=1;
    var com = entity.Get<Component136>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component312>())
   {
    q+=1;
    var com = entity.Get<Component312>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component41>())
   {
    q+=1;
    var com = entity.Get<Component41>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
