using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System97 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component173>().Inc<Component218>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component134>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component134>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component112>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component112>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component39>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component39>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component232>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component232>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
