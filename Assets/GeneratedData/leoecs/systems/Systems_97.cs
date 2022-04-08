using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System97 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component173,Component218> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component134>())
   {
    q+=1;
    var com = entity.Get<Component134>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component112>())
   {
    q+=1;
    var com = entity.Get<Component112>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component39>())
   {
    q+=1;
    var com = entity.Get<Component39>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component232>())
   {
    q+=1;
    var com = entity.Get<Component232>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
