using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System8 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component103>().Inc<Component326>().Inc<Component39>().Inc<Component401>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component417>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component417>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component205>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component205>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component161>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component161>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component83>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component83>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
