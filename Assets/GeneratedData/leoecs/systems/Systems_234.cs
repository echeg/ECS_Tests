using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System234 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component193> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component137>())
   {
    q+=1;
    var com = entity.Get<Component137>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component325>())
   {
    q+=1;
    var com = entity.Get<Component325>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component205>())
   {
    q+=1;
    var com = entity.Get<Component205>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component163>())
   {
    q+=1;
    var com = entity.Get<Component163>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
